using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TestNinja.Reservation;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests

    {
        [TestMethod]
        public void CabBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrage
            var _reservation = new Reservation();

            //Act
            bool result = _reservation.CanBeCancelledBy(new Reservation.User {IsAdmin = true});

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CabBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            //Arrage
            var user = new User();
            var _reservation = new Reservation {MadeBy=user};
            
            //Act
            bool result = _reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
