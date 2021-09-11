﻿using NUnit.Framework;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetUp()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        protected void TearDown()
        {
            app.Stop();
        }
    }
}
