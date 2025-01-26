using System.Runtime.Intrinsics.X86;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //            What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            //Answer: b) To define a blueprint for a class
            #endregion

            #region Q2
            //            Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public

            //Answer: a) private
            #endregion


            #region Q3
            //            Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are read only

            //Answer: b) No
            #endregion

            #region Q4
            //            In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace

            //Answer: b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            //            Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements

            //Answer: d) implements
            #endregion

            #region Q6
            //            Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private

            //Answer: a) Yes
            #endregion



            #region Q7
            //            In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed

            //Answer: b) No, all members are implicitly public
            #endregion

            #region Q8
            //            What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution

            //Answer: b) To provide a clear separation between interface and class members
            #endregion

            #region Q9
            //            In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static

            //Answer: b) No, interfaces cannot have constructors
            #endregion


            #region Q10
            //            How can a C# class implement multiple interfaces?
            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces

            //Answer: c) By separating interface names with commas
            #endregion



            #region Q1 Part 2
            //            using System;

            //interface IShape
            //        {
            //            double Area { get; }
            //            void DisplayShapeInfo();
            //        }

            //        interface ICircle : IShape
            //        {
            //            double Radius { get; set; }
            //        }

            //        interface IRectangle : IShape
            //        {
            //            double Width { get; set; }
            //            double Height { get; set; }
            //        }

            //        class Circle : ICircle
            //        {
            //            public double Radius { get; set; }

            //            public double Area => Math.PI * Radius * Radius;

            //            public void DisplayShapeInfo()
            //            {
            //                Console.WriteLine($"Circle with Radius: {Radius}, Area: {Area}");
            //            }
            //        }

            //        class Rectangle : IRectangle
            //        {
            //            public double Width { get; set; }
            //            public double Height { get; set; }

            //            public double Area => Width * Height;

            //            public void DisplayShapeInfo()
            //            {
            //                Console.WriteLine($"Rectangle with Width: {Width}, Height: {Height}, Area: {Area}");
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                ICircle circle = new Circle { Radius = 5 };
            //                circle.DisplayShapeInfo();

            //                IRectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            //                rectangle.DisplayShapeInfo();
            //            }
            //        }
            #endregion


            #region Q2 Part 2
            //            using System;

            //interface IAuthenticationService
            //        {
            //            bool AuthenticateUser(string username, string password);
            //            bool AuthorizeUser(string username, string role);
            //        }

            //        class BasicAuthenticationService : IAuthenticationService
            //        {
            //            public bool AuthenticateUser(string username, string password)
            //            {
            //                // Simulate authentication logic
            //                return username == "admin" && password == "password";
            //            }

            //            public bool AuthorizeUser(string username, string role)
            //            {
            //                // Simulate authorization logic
            //                return username == "admin" && role == "Admin";
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                IAuthenticationService authService = new BasicAuthenticationService();

            //                bool isAuthenticated = authService.AuthenticateUser("admin", "password");
            //                Console.WriteLine($"User Authenticated: {isAuthenticated}");

            //                bool isAuthorized = authService.AuthorizeUser("admin", "Admin");
            //                Console.WriteLine($"User Authorized: {isAuthorized}");
            //            }
            //        }
            #endregion



            #region Q3 Part 2
//            using System;

//interface INotificationService
//        {
//            void SendNotification(string recipient, string message);
//        }

//        class EmailNotificationService : INotificationService
//        {
//            public void SendNotification(string recipient, string message)
//            {
//                Console.WriteLine($"Sending Email to {recipient}: {message}");
//            }
//        }

//        class SmsNotificationService : INotificationService
//        {
//            public void SendNotification(string recipient, string message)
//            {
//                Console.WriteLine($"Sending SMS to {recipient}: {message}");
//            }
//        }

//        class PushNotificationService : INotificationService
//        {
//            public void SendNotification(string recipient, string message)
//            {
//                Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
//            }
//        }

//        class Program
//        {
//            static void Main()
//            {
//                INotificationService emailService = new EmailNotificationService();
//                emailService.SendNotification("user@example.com", "Hello via Email");

//                INotificationService smsService = new SmsNotificationService();
//                smsService.SendNotification("1234567890", "Hello via SMS");

//                INotificationService pushService = new PushNotificationService();
//                pushService.SendNotification("DeviceID123", "Hello via Push Notification");
//            }
//        }
        #endregion


    }
    }
}
