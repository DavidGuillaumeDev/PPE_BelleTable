﻿using System;
using System.Collections.Generic;
using System.IO;
using QRCoder;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace PPE_BelleTable
{
    interface Interface
    {
        public static int MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("...................Bienvenue au salon............");
            Console.WriteLine("1 : Ajouter un participant ");
            Console.WriteLine("2 : Rechercher un participant");
            Console.WriteLine("3 : Quitter");
            Console.WriteLine("");
            Console.Write("Votre choix : - ");
            try
            {
                String LeChoix = Console.ReadLine();
                return int.Parse(LeChoix);
            }
            catch
            {
                return 0; //Erreur de Saisie
            }
        }

        public static void TraiterChoix(int LeChoix, DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            switch (LeChoix)
            {
                case 0:
                    Console.WriteLine("Les choix possibles sont 1, 2, 3 ou 4. Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.WriteLine("Vous souhaitez ajouter un participant. Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                    //AjouterParticipant(DataBaseConnection);
                    break;

                case 2:
                    Console.WriteLine("Vous souhaitez rechercher un participant. Appuyez sur une touche pour continuer");
                    Console.ReadKey();
                    RechercherParticipant(DataBaseConnection, TheReader);
                    break;

                case 3:
                    Console.WriteLine("Au revoir.....");
                    break;
            }
        }

        public static void FabriquerBadge(Participant UnParticipant)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            string qrBrut = "L'email du participant est : " + UnParticipant.Email;
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrBrut.ToString(),QRCodeGenerator.ECCLevel.Q );

            Base64QRCode qrCode = new Base64QRCode(qrCodeData);
            string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

            StreamWriter monStreamWriter = new StreamWriter(@"BadgeSalon.html");

            String strImage = "<img src=\"data:image/png;base64," + qrCodeImageAsBase64 + "\">";
            monStreamWriter.WriteLine("<html>");
            monStreamWriter.WriteLine("<body>");
            string temptext = "<P>" + UnParticipant.Nom + "<P>";
            monStreamWriter.WriteLine(temptext);
            temptext = "<P>" + UnParticipant.Prenom + "<P>";
            monStreamWriter.WriteLine(temptext);
            monStreamWriter.WriteLine(strImage);
            monStreamWriter.WriteLine("<body>");
            monStreamWriter.WriteLine("<html>");
            
            monStreamWriter.Close();
            Process lancement = new Process();
            lancement.StartInfo.FileName = @"C:/Users/guill/source/repos/PPE_BelleTable/bin/Debug/netcoreapp3.1/BadgeSalon.html";
            lancement.Start();
            //Console.ReadKey()
        }

        public static void RechercherParticipant(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            String NomParticipant;
            Console.Clear();
            Console.WriteLine(".....................................................");
            Console.Write("...................Nom du participant recherché ?");
            NomParticipant = Console.ReadLine();

            string query = "select id,nom,prenom,email from participant where nom =?nom;";
            query = Tools.PrepareLigne(query, "?nom", Tools.PrepareChamp(NomParticipant, "Chaine"));

            var cmd = new MySqlCommand(query, DataBaseConnection.Connection);
            List<Participant> LesParticipantsTrouves = new List<Participant>();
            TheReader = cmd.ExecuteReader(); //On est arrivé à la fin, il faut recharger le reader
            while (TheReader.Read())
            {
                Participant UnParticipant = new Participant
                {
                    ParticipantID = (int)TheReader["id"],
                    Nom = (string)TheReader["nom"],
                    Prenom = (string)TheReader["prenom"],
                    Email = (string)TheReader["email"]

                };
                LesParticipantsTrouves.Add(UnParticipant);
            }
            if (LesParticipantsTrouves.Count > 0)
            {
                Console.WriteLine("--------------------Participants Trouvés------------------");
                foreach (Participant UnParticipant in LesParticipantsTrouves)
                {
                    Console.WriteLine(UnParticipant.ParticipantID.ToString() + ", " + UnParticipant.Prenom + ", " + UnParticipant.Nom + ", " + UnParticipant.Email);
                }
                Console.WriteLine("--------------------Saisissez l'ID------------------");
                int IdAImprimer = int.Parse(Console.ReadLine());
                int index = LesParticipantsTrouves.FindIndex(requete => requete.ParticipantID == IdAImprimer);
                if(index > -1)
                {
                    Participant LeParticipantAImprimer = LesParticipantsTrouves[index];
                    FabriquerBadge(LeParticipantAImprimer);
                }
            }
            else
                Console.WriteLine("Je n'ai trouvé personne.");
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey();
            TheReader.Close();

        }

        public static void AjouterParticipant(DBConnection DataBaseConnection, String Nom, String Prenom, String Email)
        {
            Participant UnParticipant = new Participant();
            String NomParticipant, PrenomParticipant, EmailParticipant;
            NomParticipant = Nom;
            PrenomParticipant = Prenom;
            EmailParticipant = Email;

            UnParticipant.Nom = NomParticipant;
            UnParticipant.Prenom = PrenomParticipant;
            UnParticipant.Email = EmailParticipant;
            if (DataBaseConnection.IsConnect())
            {
                try
                {
                    String sqlString = "INSERT INTO participant(nom,prenom,email) VALUES(?nom,?prenom,?email)";
                    sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(UnParticipant.Nom, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(UnParticipant.Prenom, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?email", Tools.PrepareChamp(UnParticipant.Email, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                    cmd.ExecuteNonQuery();
                    FabriquerBadge(UnParticipant);
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
                }
                Console.WriteLine(UnParticipant.GetParticipant() + "\n");
            }
        }
        
        public static void AjouterIncident(DBConnection DataBaseConnection, String Objet, String Description)
        {
            Incident UnIncident = new Incident();

            UnIncident.Objet = Objet;
            UnIncident.Description = Description;
            if (DataBaseConnection.IsConnect())
            {
                try
                {
                    String sqlString = "INSERT INTO incidents(objet,description) VALUES(?objet,?description)";
                    sqlString = Tools.PrepareLigne(sqlString, "?objet", Tools.PrepareChamp(UnIncident.Objet, "Chaine"));
                    sqlString = Tools.PrepareLigne(sqlString, "?description", Tools.PrepareChamp(UnIncident.Description, "Chaine"));
                    var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
                }
            }
        }   
    }
}
