using NUnit.Framework;
using Banque;
using System;

namespace BanqueTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Program.populateUser();
            Program.populateProduct();
        }

        [Test]
        public void FoncTestPopulateUser()
        {
            if (Program.Utilisateurs.Count > 0)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void FoncTestPopulateProduct()
        {
            if (Program.Produits.Count > 0)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void UnitTestGetUser()
        {
            if (Program.getUser("Norman", "nono") is Utilisateur)
            {
                Assert.Pass();
            }
            Assert.Fail("Get user function don't return object type Utilisateur");
        }

        [Test]
        public void FoncTestUtilisateurAchat()
        {
            Utilisateur user = Program.Utilisateurs[0];
            Produit product = Program.Produits[0];
            int OldProductNumber = user.Produits.Count;
            if (user.Solde >= product.Prix)
            {
                if (user.Achat(product) == 1)
                    if (OldProductNumber < user.Produits.Count)
                    {
                        Assert.Pass();
                    }
            }
            else if (user.Solde < product.Prix)
            {
                if (user.Achat(product) == -1 && OldProductNumber == user.Produits.Count)
                    Assert.Pass();
            }
            Assert.Fail("Buy product function didn't work correctly");
        }

        [Test]
        public void UnitTestUtilisateurDeduction()
        {
            Utilisateur user = Program.Utilisateurs[0];
            if (user.Deduction(1) == 1 && user.Deduction(999999) == -1)
            {
                Assert.Pass();
            }
            Assert.Fail("Deduction function in Utilisateur class don't working correctly");
        }

        [Test]
        public void FoncTestSuccessUtilisateurDeduction()
        {
            Utilisateur user = Program.Utilisateurs[0];
            int oldSolde = user.Solde;
            int amount = 1;
            user.Deduction(amount);
            if (user.Solde == oldSolde - amount)
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void FoncTestFailureUtilisateurDeduction()
        {
            Utilisateur user = Program.Utilisateurs[0];
            int oldSolde = user.Solde;
            int amount = 100;
            user.Deduction(amount);
            if (user.Solde == oldSolde)
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void UnitTestSuccessUtilisateurCrediter()
        {
            Utilisateur user = Program.Utilisateurs[0];
            if (user.Crediter(10) == 1)
                Assert.Pass();
            Assert.Fail();
        }

        [Test]
        public void IntegrationTestUtilisateurBuyProduct()
        {
            Utilisateur user = Program.Utilisateurs[0];
            Produit tesla = new Produit("Tesla Roadster Founders Edition", 215000);
            if (user.Achat(tesla) == -1)
                if (user.Crediter(215000) == 1)
                    if (user.Achat(tesla) == 1)
                        Assert.Pass();
                    else
                        Assert.Fail("Buy tesla didn't work");
                else
                    Assert.Fail("Credit function didn't work correctly");
            else
                Assert.Fail("User can buy product even if he doesn't sufficient fund");
        }
    }
}