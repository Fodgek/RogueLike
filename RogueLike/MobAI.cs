namespace RogueLike
{
    internal class MobAI : GameObjectBehaviour
    {
        private Random random = new Random();
        private int rand;
        public MobAI() { }
        public void RandAct(GameObject obj) {
            rand = random.Next(7);
            switch(rand) {
                case 0:
                    MoveUp(obj); Attack(obj); 
                    break;
                case 1:
                    MoveUpRight(obj); Attack(obj);
                    break;
                case 2:
                    MoveRight(obj); Attack(obj);
                    break;
                case 3:
                    MoveDownRight(obj); Attack(obj);
                    break; 
                case 4:
                    MoveDown(obj); Attack(obj); 
                    break;
                case 5:
                    MoveDownLeft(obj); Attack(obj);
                    break;
                case 6:
                    MoveLeft(obj); Attack(obj);
                    break;
                case 7:
                    MoveUpLeft(obj); Attack(obj);
                    break;
            }
        }
    }
}
