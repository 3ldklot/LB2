using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Lab2.Matrix;

namespace Lab2
{

    public enum ACCESS
    {
        READONLY = 1,
        WRITEONLY = 2,
        READ_WRITE = 3,
        NO_ACCESS = 0
    }

    public struct objectAccess 
    {
        public ACCESS accessesObj1;
        public ACCESS accessesObj2;
        public ACCESS accessesObj3;
        public ACCESS accessesObj4;
    }

    //Dictionary nameObj

    public class Matrix
    {

        private int _rows = 8;
        private int _columns = 4;

        private Dictionary<string, objectAccess> access2 = new Dictionary<string, objectAccess>
        {
            { "admin",  new objectAccess { accessesObj1 = ACCESS.READ_WRITE, accessesObj2 = ACCESS.READ_WRITE, accessesObj3 = ACCESS.READ_WRITE, accessesObj4 = ACCESS.READ_WRITE }},
            { "Vasya", new objectAccess { accessesObj1 = ACCESS.READONLY, accessesObj2 = ACCESS.READONLY, accessesObj3 = ACCESS.READONLY, accessesObj4 = ACCESS.READ_WRITE }},
            { "Anton" , new objectAccess { accessesObj1 = ACCESS.READ_WRITE, accessesObj2 = ACCESS.READ_WRITE, accessesObj3 = ACCESS.READ_WRITE, accessesObj4 = ACCESS.READ_WRITE }},
            { "Gwidon", new objectAccess { accessesObj1 = ACCESS.WRITEONLY, accessesObj2 = ACCESS.READONLY, accessesObj3 = ACCESS.READONLY, accessesObj4 = ACCESS.WRITEONLY }},
            { "Montana", new objectAccess { accessesObj1 = ACCESS.READ_WRITE, accessesObj2 = ACCESS.READ_WRITE, accessesObj3 = ACCESS.WRITEONLY, accessesObj4 = ACCESS.READONLY }},
            { "Kurt Kobein" , new objectAccess { accessesObj1 = ACCESS.READ_WRITE, accessesObj2 = ACCESS.READ_WRITE, accessesObj3 = ACCESS.WRITEONLY, accessesObj4 = ACCESS.READONLY }},
            { "VIP", new objectAccess { accessesObj1 = ACCESS.READ_WRITE, accessesObj2 = ACCESS.READ_WRITE, accessesObj3 = ACCESS.READ_WRITE, accessesObj4 = ACCESS.READONLY }},
            { "Varvara", new objectAccess { accessesObj1 = ACCESS.WRITEONLY, accessesObj2 = ACCESS.READONLY, accessesObj3 = ACCESS.READONLY, accessesObj4 = ACCESS.READ_WRITE }}
        };
        

        //private string[][] access = new string[][]
        //{
        //    new string[] { "admin", "3", "3", "3", "3" },
        //    new string[] { "Vasya", "1", "1", "1", "3" },
        //    new string[] { "Anton", "2", "2", "2", "1" },
        //    new string[] { "Gwidon", "2", "1", "1", "2" },
        //    new string[] { "Montana", "3", "3", "2", "1" },
        //    new string[] { "Kurt Kobein", "3", "3", "3", "2" },
        //    new string[] { "VIP", "1", "1", "1", "1" },
        //    new string[] { "Varvara", "2", "1", "1", "3" }
        //};

        public string getName(string name) 
        {
            foreach (var key in access2.Keys) 
            {
                if (key == name) return key;
            }
            return "No info";
        }
        public ACCESS getAccessInfo(string name, int objectNumber) 
        {
            if (objectNumber == 1)
                return access2[name].accessesObj1;
            if (objectNumber == 2)
                return access2[name].accessesObj2;
            if (objectNumber == 3)
                return access2[name].accessesObj3;
            if (objectNumber == 4)
                return access2[name].accessesObj4;
            return ACCESS.NO_ACCESS;
        }

        public void writeANewRight(string name, ACCESS newRight, int objectNumber) 
        {
            //access2.Add({ "asd", new objectAccess { accessesObj1 = ACCESS.READ_WRITE, accessesObj2 = ACCESS.READ_WRITE, accessesObj3 = ACCESS.READ_WRITE, accessesObj4 = ACCESS.READ_WRITE } })
            if (objectNumber == 1) 
                 access2[name].accessesObj1 = newRight;
            if (objectNumber == 2)
                 access2[name].accessesObj2 = newRight;
            if (objectNumber == 3)
                 access2[name].accessesObj3 = newRight;
            if (objectNumber == 4)
                 access2[name].accessesObj4 = newRight;
        }

        public string grantAccess(string who, string toWho, int objectNumber, ACCESS whichLevel) 
        {
            ACCESS hasRightToGrant = this.getAccessInfo(who, objectNumber);
            ACCESS stillHasNoRight = this.getAccessInfo(toWho, objectNumber);


            if (hasRightToGrant == ACCESS.NO_ACCESS)
                return "Granter has no right to do that";
            else if (stillHasNoRight == whichLevel)
                return ("User " + toWho + " already has that right");
            else 
            {
                if (hasRightToGrant > stillHasNoRight)
                {

                }
                //for (int i = 0; i < _rows; i++)
                //{
                //    if (access[i][0] == toWho)
                //    {
                //        if (int.Parse(access[i][objectNumber]) < levelParsed)
                //        {
                //            access[i][objectNumber] = whichLevel;
                //            return ("User " + toWho + " was granted with access to object " + objectNumber + "\nof level " + whichLevel);
                //        }
                //        else return ("Lol user " + toWho + " doesn't need your permission");
                //    }
                //}
            }
            return "Something happened";
        }

        public Matrix()
        {
            
        }        
        public void setRows(int rows) { _rows = rows; }
        public void setColumns (int columns) { _columns = columns;}
        public int getRows() { return _rows;}
        public int getColumns() { return _columns;}


    }
}
