using System;

namespace BinaryTreeUniversity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector financiero";
            vicFinPosition.Salary = 750;
            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;
            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 310;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector académico";
            vicAcadPosition.Salary = 780;
            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe Regional";
            jefeRegPosition.Salary = 640;
            Position secReg2Position = new Position();
            secReg2Position.Name = "Secretario Regional 2";
            secReg2Position.Salary = 360;
            Position secReg1Position = new Position();
            secReg1Position.Name = "Secretario Regional 1";
            secReg1Position.Salary = 400;
            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2";
            asist2Position.Salary = 170;
            Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1";
            asist1Position.Salary = 250;
            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;


            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);

            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);

            universityTree.CreatePosition(universityTree.Root, asist1Position, secReg1Position.Name);

            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");

            Console.ReadLine();
        }
    }
}
