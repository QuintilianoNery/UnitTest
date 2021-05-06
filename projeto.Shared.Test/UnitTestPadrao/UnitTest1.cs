using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projeto.Shared.Test;

namespace UnitTestPadrao
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Inicializar()
        {
            // usuario = new usuario();
        }

        [TestMethod]
        public void VerificaIdadeDeRisco_Idade18Anos_ResultadoTrue()
        {
            int idade = 18;
            bool resultado = Helper.verificaIdadeDeRisco(idade);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificaIdadeDeRisco_Idade15Anos_ResultadoFalse()
        {
            int idade = 15;
            bool resultado = Helper.verificaIdadeDeRisco(idade);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void VerificaNomeDeRisco_Quintiliano_True()
        {
            string nome = "Quintiliano";
            bool resultado = Helper.verificaNomeDeRisco(nome);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificaNomeDeRisco_Corona_False()
        {
            string nome = "Corona";
            bool resultado = Helper.verificaNomeDeRisco(nome);
            Assert.IsFalse(resultado);
        }

    }
}
