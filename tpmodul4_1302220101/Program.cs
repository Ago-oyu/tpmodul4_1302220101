
namespace tpmodul4_1302220101;

public class Program
{
    public static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.Write("Nama Kecamatan : ");
        String kecamatan = Console.ReadLine();
        Console.WriteLine("Kode Pos : " + kp.GetKodePos(kecamatan));

        DoorMachine dm = new DoorMachine();
        Console.Write("Trigger : ");
        String trigger = Console.ReadLine();
        dm.changeState(trigger);
        Console.Write("Trigger : ");
        trigger = Console.ReadLine();
        dm.changeState(trigger);

    }
}
