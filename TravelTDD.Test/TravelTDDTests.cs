using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Marty Kent 7/1/2018
namespace TravelTDD.Test
{
    [TestFixture]
    class TravelTDDTest
    { //class
        [Test]
        public void Test_Default_CTR()
        {
            var travel = new Travel();

            var result = travel.FName = "FName";

            Assert.That(result, Is.EqualTo("FName"));
        }

        [Test]
        public void Test_LastName_Prop()
        {
            var travel = new Travel();

            var result = travel.LName = "LName";

            Assert.That(result, Is.EqualTo("LName"));
        }
        [Test]
        public void Test_Address_Prop()
        {
            var travel = new Travel();

            var result = travel.Address = "";

            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void Test_Address_Email()
        {
            var travel = new Travel();

            var result = travel.Email = "";

            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void Test_Date_Travel_Method()
        {
            var travel = new Travel();

            var result = travel.GetDate(9, 30, 2018);

            Assert.That(result, Is.EqualTo("9/8/2018"));
        }
        //[Test]
        //public void Test_Total_Travel_Time_Method()
        //{
        //    var travel = new Travel();

        //    var result = travel.TtlTravel(5);

        //    Assert.That(result, Is.EqualTo("5"));
        //}

        [Test]
        public void Selection_Method()
        {
            var travel = new Travel();

            var result = travel.GetSelection(5);

            Assert.That(result, Is.EqualTo("Cali"));
        }

        [Test]
        public void Selection_Method_4_Georgia()
        {
            var travel = new Travel();

        var result = travel.GetSelection(4);

        Assert.That(result, Is.EqualTo("Georgia"));
        }


    [Test]
    public void Selection_Method_3_Florida()
    {
        var travel = new Travel();

        var result = travel.GetSelection(3);

        Assert.That(result, Is.EqualTo("Florida"));
    }

    [Test]
    public void Selection_Method_2_Nashville()
    {
        var travel = new Travel();

        var result = travel.GetSelection(2);

        Assert.That(result, Is.EqualTo("Nashville"));
    }

    [Test]
    public void Selection_Method_1_Put_in_Bay()
    {
        var travel = new Travel();

        var result = travel.GetSelection(1);

        Assert.That(result, Is.EqualTo("Put in Bay"));
    }

    [Test]
    public void Selection_Method_0_Stay_Home()
    {
        var travel = new Travel();

        var result = travel.GetSelection(0);

        Assert.That(result, Is.EqualTo("Stay Home"));
    }

    [Test]
    public void Selection_Method_Greater_Than_5()
    {
        var travel = new Travel();

        var result = travel.GetSelection(5);

        Assert.That(result, Is.EqualTo("Cali"));
    }

    [Test]
    public void Selection_Method_Greater_Than_5_Destination()
    {
        var travel = new Travel();

        var result = travel.GetSelection(6);

        Assert.That(result, Is.EqualTo("The World is Yours"));


    //} Don't understand what was being asked for. Directions were repetitive. 
    //    [Test]
    //    public void Test_Destination_Class()
    //    {
    //        var destination = new Destination();

    //        var result = destination.GetSelection(9/13/2018);

    //        Assert.That(result, Is.EqualTo("Cali"));
    //    }

    }
}

    

    

