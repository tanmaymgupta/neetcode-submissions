public class Solution {
    public record Car (int Distance, int Speed);
    public int CarFleet(int target, int[] position, int[] speed) {
        Car[] cars = new Car[position.Length];
        
        for(int i=0; i<position.Length; i++)
        {
            cars[i] = new Car(target-position[i], speed[i]);
        }

        cars = cars.OrderBy(c => c.Distance).ToArray();

        int fleetCount = 0;
        double max_time = 0;
        foreach(Car car in cars)
        {
            double car_time = (double)car.Distance / (double)car.Speed;
            if(car_time > max_time)
            {
                fleetCount ++;
                max_time = car_time;
            }
        }
        return fleetCount;
    }
}

/*

position Distance speed time  
4        6        2      3
1        9        2      4.5
0        10       1      10
7        3        1      3


Distance
3         3
6         3
9         4.5
10        10

*/