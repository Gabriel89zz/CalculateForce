using CalculateForce;

Force blow = new Force();
blow.Mass = 23;
blow.Acceleration = 56;
Console.WriteLine("The force of the blow with mass of: "+blow.Mass+ " Kg and with acceleration of: "+blow.Acceleration+ " m/s² It is: " + blow.CalculeteForce(blow) +" Newtons");
Console.ReadKey();