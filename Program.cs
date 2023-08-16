// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    const int FIELDSIZE = 10;
    const int VALID_POSITIONS = 20;

    static void Main(string[] args) 
    {
        Console.WriteLine("Result ==> " + validate_battlefield(TestCases.failFieldI));
    }

    static bool validate_battlefield(List<List<int>> field) 
    {
        List<List<int>> positionsList = GetPositionsList(field);
        if (positionsList == null || positionsList.Count != VALID_POSITIONS)
        {
            Console.WriteLine("ERROR: Invalid input");
            return false;
        } 

        Fleet fleet = new Fleet();
        fleet = DefineShipsRoute(ref fleet, positionsList);

        if (fleet.FleetStatus())
        {
            fleet.ShowFleetDetail();
            Console.ForegroundColor = ConsoleColor.Green;
        } else Console.ForegroundColor = ConsoleColor.Red;

        //return true;
        return fleet.FleetStatus();
    }

    static void CheckValidShipPosition(List<int> position, List<List<int>> list, System.Action failureCallback)
    {
        int coordX = position[0];
        int coordY = position[1];
        if (list.IsCoordExistInList(coordX-1,coordY+1) 
            || list.IsCoordExistInList(coordX+1,coordY+1) 
            || (list.IsCoordExistInList(coordX+1,coordY) && list.IsCoordExistInList(coordX,coordY+1))
            )
        {
            Console.WriteLine("DECTECT FAILD CHECK AT [{0},{1}]!!", coordX, coordY);
            failureCallback();
        }
    }

    static List<List<int>> IdentifyShip(List<int> shipPosition, List<List<int>> positionsList, System.Action failurecallback)
    {
        int coordX = shipPosition[0];
        int coordY = shipPosition[1];
        List<List<int>> tempShip = new List<List<int>>();
        CheckValidShipPosition(shipPosition, positionsList, () => { failurecallback();});      
        if (positionsList.IsCoordExistInList(coordX,coordY+1))
        {
            int i = 0;
            while(positionsList.IsCoordExistInList(coordX,coordY+i))
            {
                List<int> tempPosition = new List<int>{coordX,coordY+i};
                CheckValidShipPosition(tempPosition, positionsList, () => { failurecallback();});
                tempShip.Add(tempPosition);
                i++;
            }
            return tempShip;
        }
        if (positionsList.IsCoordExistInList(coordX+1,coordY))
        {
            int i = 0;
            while(positionsList.IsCoordExistInList(coordX+i,coordY))
            {
                List<int> tempPosition = new List<int>{coordX+i,coordY};
                CheckValidShipPosition(tempPosition, positionsList, () => { failurecallback();});
                tempShip.Add(tempPosition);
                i++;
            }
            return tempShip;
        }
        tempShip.Add(shipPosition);
        return tempShip;   
    }

    static bool IsCoordExistInList(int x, int y, List<List<int>> list)
    {
        return list.Any(item => item[0]==x && item[1]==y);
    }

    static List<List<int>> GetPositionsList(List<List<int>> list)
    {
        List<List<int>> listResult = new List<List<int>>();
        int i=0;
        foreach (List<int> item in list)
        {
            int j=0;
            foreach (int items in item)
            {
                if (items == 1) 
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    listResult.Add(new List<int>{j,i});
                } else Console.ResetColor();
                Console.Write(items + " ");
                j++;
            }
            Console.ResetColor();
            Console.WriteLine();
            i++;
        }
        Console.WriteLine();
        return listResult;
    }

    public static Fleet DefineShipsRoute(ref Fleet fleet, List<List<int>> positionsList)
    {
        var tempPositionList = positionsList;
        if (positionsList==null || positionsList.Count==0)
        {
            return fleet;
        } else {
            List<List<int>> ship = IdentifyShip(positionsList[0], positionsList, () => { positionsList.Clear();});
            fleet.AddShip(ship, () => { positionsList.Clear();});
            tempPositionList.ReMoveSubList(ship);
        }
        return DefineShipsRoute(ref fleet, tempPositionList);
    }
}

struct Fleet
{
    public List<List<List<int>>> battleShips;
    public List<List<List<int>>> cruisers;
    public List<List<List<int>>> destroyers;
    public List<List<List<int>>> submarines;

    public Fleet()
    {
        this.battleShips = new List<List<List<int>>>();
        this.cruisers = new List<List<List<int>>>();
        this.destroyers = new List<List<List<int>>>();
        this.submarines = new List<List<List<int>>>();
    }

    public void ShowFleetDetail()
    {
        Console.WriteLine("----- FLEET DETAILS ----");
        Console.Write("Number of Battleships: ");
        ShowShipsDetail(this.battleShips);
        Console.Write("Number of Cruisers: ");
        ShowShipsDetail(this.cruisers);
        Console.Write("Number of Destroyers: ");
        ShowShipsDetail(this.destroyers);
        Console.Write("Number of Submarines: ");
        ShowShipsDetail(this.submarines);
    }

    private void ShowShipsDetail(List<List<List<int>>> ships)
    {
        Console.WriteLine(ships.Count());
        foreach(List<List<int>> item in ships)
        {            
            item.CoordsPrint();
            Console.WriteLine();
        }
    }

    public bool FleetStatus()
    {
        return (this.battleShips.Count==1 && this.cruisers.Count==2 && this.destroyers.Count==3 && this.submarines.Count==4);
    }

    public void AddShip(List<List<int>> shipCoords, System.Action failurecallback)
    {
        int shipLength = shipCoords.Count;
        if (shipLength==1 && this.submarines.Count<4) 
        {
            this.submarines.Add(shipCoords);
            return;
        }
        if (shipLength==2 && this.destroyers.Count<3) 
        {
            this.destroyers.Add(shipCoords);
            return;
        }
        if (shipLength==3 && this.cruisers.Count<2) 
        {
            this.cruisers.Add(shipCoords);
            return;
        }
        if (shipLength==4 && this.battleShips.Count<1) 
        {
            this.battleShips.Add(shipCoords);
            return;
        }
        failurecallback();
    }
}
