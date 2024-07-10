using ConsoleApp1;

class Program
{
    class Atm
    {

        int mebleg { get; set; }
        string password { get; set; }

        public Atm(int mebleg, string password)
        {
            this.mebleg = mebleg;
            this.password = password;

        }

        bool Check()
        {

            Console.Write("Password: ");
            string oldPass = Console.ReadLine();

            return oldPass == password;
        }

        public void balans()
        {
            if (Check()) {
                Console.WriteLine(mebleg);
            }

            else
            {
                throw new PassException("Wrong Password!!");
            }
        }

        public void cashIn() {

            if (Check())
            {
                Console.Write("Daxil Edilecek Mebleg: ");
                int a = int.Parse(Console.ReadLine());
                mebleg += a;

                mebleg += a;
            }

            else
            {
                throw new PassException("Wrong Password!!");
            }

        }

        public void cashOut()
        {

            if (Check())
            {
                Console.Write("Cixarilacaq Mebleg: ");
                int b = int.Parse(Console.ReadLine());

                if (b <= mebleg)
                {
                    mebleg -= b;
                }

                else { throw new PassException("Not Enogh Money"); }


            }

            else
            {
                throw new PassException("Wrong Password!!");
            }

        }

        public void changePassword()
        {


            if (Check())
            {
               
                Console.Write("New Password: ");
                string newPass = Console.ReadLine();

                password = newPass;

            }

            else
            {
                throw new PassException("Wrong Password!!");
            }

        }

    }



    static void Main(string[] args)
    {

        Atm atm = new Atm(200, "12345");

        try
        {
            atm.cashIn();
            atm.cashOut();
            atm.balans();
            atm.changePassword();
            atm.cashIn();
        }
        catch (PassException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

}
