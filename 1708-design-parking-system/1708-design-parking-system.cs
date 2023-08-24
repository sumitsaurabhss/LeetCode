public class ParkingSystem {
    int[] spaces;
    public ParkingSystem(int big, int medium, int small) {
        this.spaces = new int[] {big, medium, small};
    }
    
    public bool AddCar(int carType) {
        int i = carType - 1;
        if(this.spaces[i] > 0) {
            this.spaces[i]--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */