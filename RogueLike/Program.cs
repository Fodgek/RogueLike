using RogueLike;

var image = '#';
var wall = new GameObject(image,"Стена","Обычная стена, тут только такие",0,0);
wall.IAm();
var pl_img = '$';
var pl_HP = 5;
var player1 = new LiveObject(pl_HP,pl_img,"Игрок1","Это вы",5,5);


var room1 = new Room();
room1.AddObj(player1);
//room1.DelObj(player1);

var mass = new GameObject[10, 10];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        mass[i, j] = new GameObject();
        mass[5, 5] = new LiveObject(pl_HP, pl_img, "Игрок1", "Это вы",5,5);
        mass[0, j] = new GameObject(image, "Стена", "Обычная стена, тут только такие", 0, j);
    }
    
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
       //Console.SetCursorPosition(i, 2 + j);
       Console.Write("{0,2}",mass[i, j]._img._symbol);
    }
    Console.WriteLine();
}


for (int i = 0; i < room1._SizeX; i++)
{
    for (int j = 0; j < room1._SizeY; j++)
    {
        Console.Write("{0,2}", room1._objArr[i,j]._img._symbol);
    }
    Console.WriteLine();
}