﻿using FLOCKAPI.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLOCKTESTS
{
    [TestClass]
    public class APITests
    {
        [TestMethod]
        public void ValidateUser_Success()
        {
            //Arrange
            string user = "dorito";
            string password = "contraseña";
            bool enabled = false; //por defecto

            //Act
            User usuario = new User() { UserName = user, Password = password };
            usuario.ValidateUser();

            //Assert
            Assert.IsTrue(enabled);
        }

        [TestMethod]
        public void ValidateUser_Failed()
        {
            //Arrange
            string user = "notdorito";
            string password = "notcontraseña";
            bool enabled = false; //por defecto

            //Act
            User usuario = new User() { UserName = user, Password = password };
            usuario.ValidateUser();

            //Assert
            Assert.IsFalse(enabled);
        }
    }
}
