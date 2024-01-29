using RogueLike;

var wall = new GameObject(new Image('#'),"Wall","Обычная стена, тут только такие",new Transform(0,0),new Health(10),0);
wall.Info();
var player1 = new Player(new Image('$'),"Player","Игрок",new Transform(5,5),new Health(10),1);
player1.Info();
var zombe1 = new GameObject(new Image('Z'),"Zombe","Ходячий разлагающийся труп, атакует на каждом шагу",new Transform(8,8),new Health(1),1);
zombe1.Info();
var controler = new PlayerControls();
var mobAI = new MobAI();
var game = true;
var room1 = new Room();
room1.AddObj(player1);
room1.AddObj(wall);
room1.AddObj(zombe1);
var rend = new Renderer();

while (game == true) 
{
    rend.RenderFrame(room1);
    mobAI.RandAct(zombe1);
    controler.Control(player1);
    rend.ClearFrame();
    player1.LowInfo();
    wall.LowInfo();
    zombe1.LowInfo();
    //if (player1.Dead()) game = false;
}
