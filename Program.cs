namespace Snadbox
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            string subCommand = args[0];
            Command command = this.createCommand(subCommand);
            command.execute();
        }


        // ここがファットになるようならCommandFactoryのように別クラスに分けてあげる
        private Command createCommand(string subCommand){
            swtich(subCommand){
                case "hoge":
                    return new HogeCommand();
                case "fuga":
                    //....
                
            }
        }
    }
}