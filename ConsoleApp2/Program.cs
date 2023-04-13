// See https://aka.ms/new-console-template for more information


void GetFloorNo (int numberOfFloors, int bulbWeight, int i=1, int numberOfRestries =1)
{

    if (bulbWeight == i)
    {
        Console.WriteLine("floor no: "+i);
        Console.WriteLine("number of retires: " + (numberOfRestries ));
        return;
    }
    else
    {
        if (bulbWeight > i)
        {
            if (numberOfFloors - i == 1)
                i++;
            else
                i += (numberOfFloors - i) / 2;
        }
        else if (bulbWeight < i)
        {
            numberOfFloors = i;
            i = (i - 1) / 2;
        }
        numberOfRestries++;
        GetFloorNo(numberOfFloors, bulbWeight, i, numberOfRestries);
    }
}



GetFloorNo(2000000, 2000000);

