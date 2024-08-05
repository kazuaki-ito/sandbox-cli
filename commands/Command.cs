namespace Commnad {
    abstract class HogeCommand : BaseCommand{
        // 横断的関心事をここで吸収する
        public object execute(object[] args...) {
            try{
                //前処理

                // command呼び出し
                this.executeInternal(args);

                //後処理
                
            }catch(Exception ex){
                // なんかエラー処理
            }
        }

        // コマンドの処理フローを記述するメソッド
        protected abstract executeInternal(object[] args...);
    }
}