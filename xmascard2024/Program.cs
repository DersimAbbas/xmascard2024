
using System;
using System.Threading;

class BeepMethodSample
{

    static void Main()
    {


        // ASCII Art Tree
        // ASCII Art Tree
        string Xmas = @"           
                @@@        @@@
                @@@@      @@@@   @@@@  @@ @@@  @@ @@@ @@      @@
                @@ @@    @@ @@  @@  @@ @@@  @@ @@@  @@ @@    @@
                @@  @@  @@  @@ @@@@@@  @@      @@       @@  @@
                @@   @@@@   @@  @@     @@      @@        @@@@
                @@    @@    @@   @@@@  @@      @@         @@
                                                         @@
                                                    @@  @@
                                                     @@@@
               @@@   @@              @@          @@
             @@   @@ @@                          @@
            @@       @@ @@@  @@ @@@  @@   @@@@ @@@@@@  @@ @@  @@      @@@    @@@@
            @@       @@@  @@ @@@  @@ @@  @@      @@    @@@  @@  @@  @@  @@  @@
            @@       @@   @@ @@      @@   @@@    @@    @@   @@  @@ @@   @@   @@@
             @@   @@ @@   @@ @@      @@     @@   @@ @@ @@       @@ @@   @@     @@
               @@@   @@   @@ @@       @@ @@@@     @@   @@       @@  @@@@ @@ @@@@";




        string heart = @"
                  ************************
                 **************************
                *****************************
                *****************************
                *****************************
                 ***************************
                  ***********************
                   *******************
                     ***************
                       ***********
                        *******
                         ***";



        string House = @"
                                                ..'''::::...
                            .::'      `'''':::..
                    '...::'               `.----.
                                            /_.--._\
                                        ,  |=   |
                                        ,/ \,|  =-|
                                    ,/ /`\ \,   |
                                    ,/ /`___`\ \,-|
                                ,/ /'.-:"";-.`\ \|
                                ,/ /` //_|_|_\\ `\ \, ,/\,
                            ,/ /`   ||_|_|_||   `\;/ /\ \,
                            ,/ /`     ||_|_|_||   ,/ /`/\`\ \,
                        ,/ /`    ==_`-------' ,/ /` ~\/~ `\ \,
                        ,/ /` __|     _       ,/ /`         =`\ \,
                    ,/ /`==_     __|___-  ,/ /` ==-=|__|     `\ \,
                    ,/ /`        --=      ,/ /`            __|-- `\ \,
                ,/ /`  |__ ..----.. = ,/ /`()    .-""""""""""-.     ()`\ \,
                / /`|     .'_.-;;-._'./ /; {__} .'.-""""""""""-.'.  {__} ;\ \
                |/`  |_| =/.; | || | ;|/` | |::|/.'  _____  '.\ |::| | `\|
                    |   |/_|_|_||_|_|_\| |=\::/||  /|_|_|\  || \::/ |
                    | -=|| | | || | | || |  || || |_|_|_|_| ||  |||_|
                    | , ||-|-|-||-|-|-||=|  JL || |_|_|_|_| ||  JL  |
                    |/_\||_|_|_||_|_|_||-|-'    ||   .:::.   ||=_   _|
                    /_ (|| | | || | | || |  ==_|| /:::::::\ || __P__|
                    /_\ \|-|-|-||-|-|-|| |     || |::(`)::| ||/\ |  `\
                    `>/ _\\_|_|_||_|_|_||-|-'|__|| \/`\+/`\/ ||||_____|
                    /_/   <-------------' |     ||()\_/Y\_/  ||/  || |
                    /  ` \_ ( ==_  __|-    |_|_  ||   / / \   || =_|| |
                `/_) | _ <`   __        |   = ||  /_/ \_\  ||   || |
                    >  /     \ == _  ==_   | -   ||           ||=  || |
                /_/   ( \  `\ _| =__   =|-__|_||-----------||_| || |
                )-._/ _\ _,-('    __.;-'-;__     `""""""""""""""""""""""    ||`""-._
                '-,._   \__.-`-;''`          ``--'`""""'""""""`""""""``-- `--'--. '
                    ```             ``         `""""""""'""""""""'""`"""""".--------'""";


        string Santa = @"
                                    |,\/,| |[_' |[_]) |[_]) \\//
                                    ||\/|| |[_, ||'\, ||'\,  ||

                    ___ __ __ ____  __  __  ____  _  _    __    __
                    // ' |[_]| |[_]) || ((_' '||' |,\/,|  //\\  ((_'
                    \\_, |[']| ||'\, || ,_))  ||  ||\/|| //``\\ ,_))
                                                               

                                                    ,;7,
                                                _ ||:|,
                                _,---,_           )\'  '|
                            .'_.-.,_ '.         ',')  j
                            /,'   ___}  \        _/   /
                .,         ,1  .''  =\ _.''.   ,`';_ |
            .'  \        (.'T ~, (' ) ',.'  /     ';',
            \   .\(\O/)_. \ (    _Z-'`>--, .'',      ;
                \  |   I  _|._>;--'`,-j-'    ;    ',  .'
            __\_|   _.'.-7 ) `'-' ""       (      ;'
            .'.'_.'|.' .'   \ ',_           .'\   /
            | |  |.'  /      \   \          l  \ /
            | _.-'   /        '. ('._   _ ,.'   \i
        ,--' ---' / k  _.-,.-|__L, '-' ' ()    ;
            '._     (   ';   (    _-}             |
            / '     \   ;    ',.__;         ()   /
            /         |   ;    ; ___._._____.: :-j
        |           \,__',-' ____: :_____.: :-\
        |               F :   .  ' '        ,  L
        ',             J  |   ;             j  |
            \            |  |    L            |  J
            ;         .-F  |    ;           J    L
            \___,---' J'--:    j,---,___   |_   |
                        |   |'--' L       '--| '-'|
                        '.,L     |----.__   j.__.'
                        | '----'   |,   '-'  }
                        j         / ('-----';
                        { ""---'--;'  }       |
                        |        |   '.----,.'";


        string Tree = @"
                    .     .  .      +     .      .          .
                    .       .      .     #       .           .
                    .      .         ###            .      .      .
                    .      .   ""#:. .:##""##:. .:#""  .      .
                        .      . ""####""###""####""  .
                    .     ""#:.    .:#""###""#:.    .:#""  .        .       .
                .             ""#########""#########""        .        .
                    .    ""#:.  ""####""###""####""  .:#""   .       .
                    .     .  ""#######""""##""##""""#######""                  .
                            .""##""#####""#####""##""           .      .
                .   ""#:. ...  .:##""###""###""##:.  ... .:#""     .
                    .     ""#######""##""#####""##""#######""      .     .
                .    .     ""#####""""#######""""#####""    .      .
                        .     ""      000      ""    .     .
                    .         .   .   000     .        .       .
            .. .. ..................O000O........................ ...... ..."
                                    ;

        string Snowman = @"
                                    .--------.
            *               .    |________|        .          *
                                    |      __|/\
                            *        .-'======\_\o/.
                                    /___________<>__\
                            ||||||  /  (o) (o)  \
                            |||||| |   _  O  _   |          .
                    .         |||||| |  (_)   (_)  |
                            ||||||  \   '---'   /    *
                            \====/   [~~~~~~~~~]
                            \\//  _/~||~`|~~~~~\_
                            _||-'`/  ||  |      \`'-._       *
                    *    .-` )|  ;   ||  |)      ;    '.
                        /    `--.|   ||  |       |      `\
                        |         \   |||||)      |-,      \
                        \       .;       _       ; |_,    |
                            `'''||` ,\     (_)     /,    `.__/
                                ||.`  '.         .'  `.
                    *          ||       ` ' ' `       \
                                ||                      ;
                .          *  ||                      |    .
                                ||                      |
                                ||                      |
                .__.-""""-.__.-""""""||                      ;.-""""""-.__.-""""-.__.
                                ||                     /
                            ||'.                 .'
                                ||  '-._  _ _  _ _.-'
                            `""""`";

        Thread ArtThread = new Thread(() =>
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Tree);
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write(Snowman);
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(House);
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Santa);
            Thread.Sleep(5000);

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

        });

        Thread melodyThread = new Thread(PlayMelody);
        Thread MessageThread = new Thread(Message);
        ArtThread.Start();
        melodyThread.Start();
        Thread.Sleep(20000);
        Message();
       
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(Xmas);
        Thread.Sleep(5000);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(heart);
        Console.ReadLine();
      








    }

    static void PlayMelody()
    {
        
        
            int C = 262;
            int D = 294;
            int E = 330;
            int F = 370;
            int G = 392;
            int A = 440;
            int Bb = 466;
            int B = 494;
            int C5 = 523;
            int E5 = 659;
            int D5 = 587;

            int note = 1000;
            int half = 1000 / 2;
            int quarter = 1000 / 4;
            int eighth = 1000 / 8;



            Thread.Sleep(2000);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(G, eighth);
            Thread.Sleep(eighth);
            Console.Beep(F, eighth);
            Thread.Sleep(eighth);
            Console.ForegroundColor = ConsoleColor.Green;




            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(B, eighth);


            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(G, eighth);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(B, quarter);
            Thread.Sleep(eighth);
            Console.Beep(B, eighth);
            Thread.Sleep(eighth);
            Console.Beep(C5, eighth);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ResetColor();


            Thread.Sleep(eighth);
            Console.Beep(B, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, eighth);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, quarter);
            Thread.Sleep(quarter);
            Console.Beep(F, quarter);
            Thread.Sleep(quarter);
            Console.Beep(G, half);
            Thread.Sleep(quarter);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, quarter);
            Thread.Sleep(quarter);
            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(quarter);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);



            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(quarter);
            Console.Beep(A, quarter);
            Thread.Sleep(eighth);
            Console.Beep(B, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D5, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, eighth);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(quarter);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);


            Console.Beep(G, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(G, eighth);
            Thread.Sleep(eighth);
            Console.Beep(F, eighth);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, quarter);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(B, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.Beep(G, eighth);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(D, quarter);
            Thread.Sleep(eighth);
            Console.Beep(B, quarter);
            Thread.Sleep(eighth);
            Console.Beep(B, eighth);
            Thread.Sleep(eighth);
            Console.Beep(C5, eighth);
            Thread.Sleep(eighth);
            Console.Beep(B, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, eighth);
            Thread.Sleep(eighth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.ResetColor();
            Console.Beep(G, quarter);
            Thread.Sleep(quarter);
            Console.Beep(E, quarter);
            Thread.Sleep(quarter);
            Console.Beep(D, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, eighth);
            Console.Beep(E, quarter);
            Thread.Sleep(quarter);
            Console.Beep(A, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(quarter);
        


        
    }
      


    


    static void Message()
    {

        string message1 = "To my beloved Fiancee I'm glad to be spending another christmas with you. ";
        string message2 = "I might be bad at showing it, but deep inside of my heart I am genuinely lucky to have you by my side. ";
        string message3 = "I love you more than you can imagine and will always be grateful for what you do for me everyday."; 
        string message4 = "I hope you feel some christmas spirit from this atleast I did my very best to create it and it was not easy ha ha.";
        string message5 = "Last But not least I Wish you Merry Christmas my love. xoxo";


        foreach (char c in message1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(c);
            Thread.Sleep(60);
        }
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.ResetColor();
        
        foreach(char c in message2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(c);
            Thread.Sleep(60);
        }
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.ResetColor();
        foreach(char c in message3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine();
        foreach(char c in message4)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(c);
            Thread.Sleep(60);
        }
        Console.ResetColor();
        Console.WriteLine();
        Thread.Sleep(1000);
        foreach (char c in message5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(c);
            Thread.Sleep(60);
        }
        Thread.Sleep(1000);



    }
      
    
}   