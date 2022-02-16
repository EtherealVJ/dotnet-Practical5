using System;
using System.Collections.Generic;
using System.Text;

namespace RentedVehicle{
internal interface VehicleInterface {

     internal decimal CalculateRent(int usageUNITS);
        internal void getData();
        internal DateOnly getLastMaintenanceDate();
        internal enum Renttype 
        {
            PERKILOMETER,PERDAY       
        }  
    }
        internal class Indica : VehicleInterface {

        internal int age, rentperunit, totalseats;
        internal string? type, numberplate;
        internal VehicleInterface.Renttype renttype;
        internal DateOnly lastmaintenancedate;

        internal Indica(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) {
            this.type = type;
            this.totalseats = totalseats;
            this.rentperunit = rentperunit;
            this.age = age; 
            this.numberplate = numberplate;
            renttype = rentType;                 
            this.lastmaintenancedate = lastmaintenancedate;
        }

        public decimal CalculateRent(int UNITS) {
            return (decimal)rentperunit*UNITS;
        }

        public void getData() 
        {
            Console.Write("\nCOMPANY : INDICA \n");
            Console.Write($"TYPE : {type}\n");
            Console.Write($"TOTAL NO. OF SEATS : {totalseats}\n");
            Console.Write($"RENT PER UNIT : {rentperunit}\n");
            Console.Write($"AGE : {age}\n");
            Console.Write($"NUMBER PLATE : {numberplate}\n");
        }

        public DateOnly getLastMaintenanceDate() {
            return lastmaintenancedate;
        }
    }

    internal class Qualis : VehicleInterface {
        internal int age, rentperunit, totalseats;
        internal string? type, numberplate;
        internal VehicleInterface.Renttype renttype;
        internal DateOnly lastmaintenancedate;

        internal Qualis(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) {
            this.type = type;
            this.totalseats = totalseats;
            this.rentperunit = rentperunit;
            this.age = age; 
            this.numberplate = numberplate;
            renttype = rentType;                 
            this.lastmaintenancedate = lastmaintenancedate;
        }

        public decimal CalculateRent(int UNITS) {
            return (decimal)rentperunit*UNITS;
        }

        public void getData() 
        {       
            Console.Write("\nCOMPANY : QUALIS \n");
            Console.Write($"TYPE : {type}\n");
            Console.Write($"TOTAL NO. OF SEATS : {totalseats}\n");
            Console.Write($"RENT PER UNIT : {rentperunit}\n");
            Console.Write($"AGE : {age}\n");
            Console.Write($"NUMBER PLATE : {numberplate}\n");
        }

        public DateOnly getLastMaintenanceDate() {
            return lastmaintenancedate;
        }
    }

    internal class DavidHarley : VehicleInterface {
        internal int age, rentperunit, totalseats;
        internal string? type, numberplate;
        internal VehicleInterface.Renttype renttype;
        internal DateOnly lastmaintenancedate;

        internal DavidHarley(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) {
            this.type = type;
            this.totalseats = totalseats;
            this.rentperunit = rentperunit;
            this.age = age; 
            this.numberplate = numberplate;
            renttype = rentType;                 
            this.lastmaintenancedate = lastmaintenancedate;
        }

        public decimal CalculateRent(int UNITS) {
            return (decimal)rentperunit*UNITS;
        }

        public void getData() 
        {
            Console.Write("\nCOMPANY : DAVID HARLEY \n");
            Console.Write($"TYPE : {type}\n");
            Console.Write($"TOTAL NO. OF SEATS : {totalseats}\n");
            Console.Write($"RENT PER UNIT : {rentperunit}\n");
            Console.Write($"AGE : {age}\n");
            Console.Write($"NUMBER PLATE : {numberplate}\n");
        }

        public DateOnly getLastMaintenanceDate() {
            return lastmaintenancedate;
        }
    }

    internal class MBenzE : VehicleInterface {
        internal int age, rentperunit, totalseats;
        internal string? type, numberplate;
        internal VehicleInterface.Renttype renttype;
        internal DateOnly lastmaintenancedate;

        internal MBenzE(string type, int totalseats, string numberplate,VehicleInterface.Renttype rentType, int age, int rentperunit, DateOnly lastmaintenancedate) {
            this.type = type;
            this.totalseats = totalseats;
            this.rentperunit = rentperunit;
            this.age = age; 
            this.numberplate = numberplate;
            renttype = rentType;                 
            this.lastmaintenancedate = lastmaintenancedate;
        }

        public decimal CalculateRent(int UNITS) {
            return (decimal)rentperunit*UNITS;
        }

        public void getData() 
        {
            Console.Write("\nCOMPANY : MERCEDES BENZ \n");
            Console.Write($"TYPE : {type}\n");
            Console.Write($"TOTAL NO. OF SEATS : {totalseats}\n");
            Console.Write($"RENT PER UNIT : {rentperunit}\n");
            Console.Write($"AGE : {age}\n");
            Console.Write($"NUMBER PLATE : {numberplate}\n");

        }

        public DateOnly getLastMaintenanceDate() {
            return lastmaintenancedate;
        }
    }

    public class TypeOfCar <T> {
        internal T CarObject;
        internal int UNITS;
        internal decimal AdvancePayment;
        internal DateOnly InitialDate,FinalDate;

        internal TypeOfCar(T CarObject) {
            this.CarObject = CarObject;
        }

        internal TypeOfCar(T CarObject, DateOnly InitialDate,DateOnly FinalDate, decimal AdvancePayment) {
            this.CarObject = CarObject;
            this.AdvancePayment=AdvancePayment;
            this.InitialDate = InitialDate;
            this.FinalDate = FinalDate;
        }


        internal int CalculateDays() {
            int day = FinalDate.Day - InitialDate.Day;
            int month = FinalDate.Month - InitialDate.Month;
            int year = FinalDate.Year - InitialDate.Year;
            

            return day + month + year;
        }
    }

    internal class RentedVehicle <T> {

    List<TypeOfCar<T>> VehicleList;

    internal RentedVehicle() {

        VehicleList = new List<TypeOfCar<T>>();
    }

    internal void AddVehicle(T CarObject) {

        TypeOfCar<T> c = new TypeOfCar<T>(CarObject);
    }

    internal void GiveForRent(T CarObject, DateOnly InitialDate, DateOnly FinalDate, decimal AdvancePay) {

        TypeOfCar<T> c = new TypeOfCar<T>(CarObject, InitialDate, FinalDate, AdvancePay);
        VehicleList.Add(c);
    }

    internal decimal CalculateRent(T CarObject, int UNITS) {

        foreach(TypeOfCar<T> c in VehicleList) {

            if(c.CarObject!.Equals(CarObject)) {
                
                c.UNITS = UNITS;
                return ((VehicleInterface)CarObject).CalculateRent(UNITS) - c.AdvancePayment;
            }
        }

        return 0;
    }


    internal decimal CalculateTotalRentToday(T CarObject, int UNITSCOVERED) {

        foreach(TypeOfCar<T> c in VehicleList) {

            if(c.CarObject!.Equals(CarObject)) {

                return (((VehicleInterface)CarObject).CalculateRent(UNITSCOVERED) - c.AdvancePayment)/c.CalculateDays();
            }
        }

        return 0;
    }

    internal void GetCheckListRentedAndAvailableVehicle() {

        foreach(TypeOfCar<T> c in VehicleList) {

            ((VehicleInterface)c.CarObject!).getData();
            Console.Write($"\nTAKEN ON RENT FROM {c.InitialDate} TO {c.FinalDate}\n");
        }
    }

    internal bool GetCheckListVehiclesInMaintenance(T CarObject) {

        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        foreach(TypeOfCar<T> c in VehicleList) {
            
            VehicleInterface car = ((VehicleInterface)c.CarObject!);
            if(c.CarObject!.Equals(CarObject) && car.getLastMaintenanceDate().CompareTo(today) > 0) 
                return true;
        }

        return false;
    }

    internal void ShowAvailabilityForBookingForGivendateByDate(DateOnly date) {

        Console.Write($"\n\nVEHICLES AVAILABLE ON : {date}");

        foreach(TypeOfCar<T> c in VehicleList) {
            
            if(c.InitialDate.CompareTo(date) > 0) {

                ((VehicleInterface)c.CarObject!).getData();
            }
        }
    }
    
}
}