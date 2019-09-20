using System;
using System.Collections.Generic;
using System.Drawing;


namespace Location.Classes
{
    class Tables
    {
        public class Users
        {
            String userId;
            String userPassword;
            bool admin;

            public Users(string userId, string userPassword, bool admin)
            {
                this.UserId = userId;
                this.UserPassword = userPassword;
                this.Admin = admin;
            }

            public string UserId { get => userId; set => userId = value; }
            public string UserPassword { get => userPassword; set => userPassword = value; }
            public bool Admin { get => admin; set => admin = value; }
        }
        public class User_Details
        {
            String email;
            String userId;
            String firstName;
            String lastName;
            String adresse;
            String phone;
            bool emailConfermed;
            DateTime brithDay;

            public User_Details(string userId, string email,string firstName, string lastName, string adresse, string phone, DateTime brithDay, bool emailConfermed)
            {
                this.Email = email;
                this.UserId = userId;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Adresse = adresse;
                this.Phone = phone;
                this.BrithDay = brithDay;
                this.EmailConfermed = emailConfermed;
            }

            public string Email { get => email; set => email = value; }
            public string UserId { get => userId; set => userId = value; }
            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public string Adresse { get => adresse; set => adresse = value; }
            public string Phone { get => phone; set => phone = value; }
            public bool EmailConfermed { get => emailConfermed; set => emailConfermed = value; }
            public DateTime BrithDay { get => brithDay; set => brithDay = value; }
        }
        public class Facture
        {
            int factureId;
            String userId;
            DateTime factureDate;
            double prix;

            public Facture(int factureId, string userId, DateTime factureDate, double prix)
            {
                this.FactureId = factureId;
                this.UserId = userId;
                this.FactureDate = factureDate;
                this.Prix = prix;
            }

            public int FactureId { get => factureId; set => factureId = value; }
            public string UserId { get => userId; set => userId = value; }
            public DateTime FactureDate { get => factureDate; set => factureDate = value; }
            public double Prix { get => prix; set => prix = value; }
        }

        public class Car
        {
            string matricule;
            String voitureName;
            String color;
            char type;
            double km;

            public Car(string matricule, string voitureName, string color, char type, double km)
            {
                this.Matricule = matricule;
                this.VoitureName = voitureName;
                this.Color = color;
                this.Type = type;
                this.Km = km;
            }

            public string Matricule { get => matricule; set => matricule = value; }
            public string VoitureName { get => voitureName; set => voitureName = value; }
            public string Color { get => color; set => color = value; }
            public char Type { get => type; set => type = value; }
            public double Km { get => km; set => km = value; }
        }
        public class CarPictures
        {
            string matricule;
            List<Image> pics;

            public CarPictures(string matricule, List<Image> img)
            {
                this.matricule = matricule;
                this.pics = img;
            }

            public string Matricule { get => matricule; set => matricule = value; }
            public List<Image> Pics { get => pics; set => pics = value; }
        }

        public class Reviews
        {
            String matricule;
            String userId;
            int review;
            String commentaire;

            public Reviews(string matricule, string userId, int review, string commentaire)
            {
                this.Matricule = matricule;
                this.UserId = userId;
                this.Review = review;
                this.Commentaire = commentaire;
            }

            public string Matricule { get => matricule; set => matricule = value; }
            public string UserId { get => userId; set => userId = value; }
            public int Review { get => review; set => review = value; }
            public string Commentaire { get => commentaire; set => commentaire = value; }
        }
        public class Contrat
        {
            int contratId;
            int factureId;
            int matricule;
            DateTime fromDate;
            DateTime toDate;

            public Contrat(int contratId, int factureId, int matricule, DateTime fromDate, DateTime toDate)
            {
                this.ContratId = contratId;
                this.FactureId = factureId;
                this.Matricule = matricule;
                this.FromDate = fromDate;
                this.ToDate = toDate;
            }

            public int ContratId { get => contratId; set => contratId = value; }
            public int FactureId { get => factureId; set => factureId = value; }
            public int Matricule { get => matricule; set => matricule = value; }
            public DateTime FromDate { get => fromDate; set => fromDate = value; }
            public DateTime ToDate { get => toDate; set => toDate = value; }
        }
        public class User_Details_Banque
        {
            String rIB_Banque;
            String userId;
            double code_Carte_Banqaire;
            int cVV;
            DateTime date_Exp_Carte;
            String num_Permier;

            public User_Details_Banque(string rIB_Banque, string userId, double code_Carte_Banqaire, int cVV, DateTime date_Exp_Carte, string num_Permier)
            {
                this.RIB_Banque = rIB_Banque;
                this.UserId = userId;
                this.Code_Carte_Banqaire = code_Carte_Banqaire;
                this.CVV = cVV;
                this.Date_Exp_Carte = date_Exp_Carte;
                this.Num_Permier = num_Permier;
            }

            public string RIB_Banque { get => rIB_Banque; set => rIB_Banque = value; }
            public string UserId { get => userId; set => userId = value; }
            public double Code_Carte_Banqaire { get => code_Carte_Banqaire; set => code_Carte_Banqaire = value; }
            public int CVV { get => cVV; set => cVV = value; }
            public DateTime Date_Exp_Carte { get => date_Exp_Carte; set => date_Exp_Carte = value; }
            public string Num_Permier { get => num_Permier; set => num_Permier = value; }
        }
    }
}
