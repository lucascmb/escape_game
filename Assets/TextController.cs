using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum Estados {start_game, room_0, desk_0, sheets_0, door_0, room_1, desk_1, sheets_1,
                          corridor_0, stairs_0, closet_0, floor_0, corridor_1, floor_1, closet_1,
                          closet_2, closet_3, stairs_1, stairs_2, stairs_3, corridor_2, corridor_3,
                          floor_2, floor_3, courtyard }
    private Estados state;

	// Use this for initializationw
	void Start () {
        state = Estados.start_game;
	}
	
	// Update is called once per frame
	void Update () {
        if(state == Estados.start_game)
        {
            state_start_game();
        }
        else if (state == Estados.room_0)
        {
            state_room();
        }
        else if (state == Estados.sheets_0)
        {
            state_sheets_0();
        }
        else if (state == Estados.door_0)
        {
            state_door_0();
        }
        else if (state == Estados.desk_0)
        {
            state_desk_0();
        }
        else if (state == Estados.room_1)
        {
            state_room_1();
        }
        else if (state == Estados.sheets_1)
        {
            state_sheets_1();
        }
        else if (state == Estados.desk_1)
        {
            state_desk_1();
        }
        else if (state == Estados.corridor_0)
        {
            state_corridor_0();
        }
        else if(state == Estados.stairs_0)
        {
            state_stairs_0();
        }
        else if(state == Estados.closet_0)
        {
            state_closet_0();
        }
        else if(state == Estados.floor_0)
        {
            state_floor_0();
        }
        else if(state == Estados.corridor_1)
        {
            state_corridor_1();
        }
        else if(state == Estados.closet_1)
        {
            state_closet_1();
        }
        else if(state == Estados.stairs_1)
        {
            state_stairs_1();
        }
        else if(state == Estados.floor_1)
        {
            state_floor_1();
        }
        else if(state == Estados.corridor_2)
        {
            state_corridor_2();
        }
        else if (state == Estados.floor_2)
        {
            state_floor_2();
        }
        else if (state == Estados.stairs_2)
        {
            state_stairs_2();
        }
        else if (state == Estados.closet_2)
        {
            state_closet_2();
        }
        else if (state == Estados.stairs_3)
        {
            state_stairs_3();
        }
        else if (state == Estados.closet_3)
        {
            state_closet_3();
        }
        else if (state == Estados.floor_3)
        {
            state_floor_3();
        }
        else if (state == Estados.corridor_3)
        {
            state_corridor_3();
        }
        else if (state == Estados.courtyard)
        {
            state_courtyard();
        }
    }

    void state_start_game()
    {
        text.text = "Você acordou em um quarto escuro e não consegue se lembrar como foi parar lá.\n\n" +
                      "Tenta se lembrar de qualquer forma mas não consegue, e então decide explorá-lo " +
                      "a fim de encontrar alguma resposta.\n\n" + 
                      "Pressione Espaço para começar o jogo";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            state = Estados.room_0;
        }
    }

    void state_room()
    {
        text.text = "Você observa que há várias folhas de papeis em cima de uma bancada, uma porta " +
                            "trancada e uma gaveta meio aberta na mesma bancada.\n\n" +
                            "Pressione G para abrir a gaveta.\n" +
                            "Pressione P para ler os papéis.\n" +
                            "Pressione D para ir até a porta.\n";
        if (Input.GetKeyDown(KeyCode.G))
        {
            state = Estados.desk_0;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            state = Estados.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            state = Estados.door_0;
        }
    }

    void state_desk_0()
    {
        text.text = "Opa, parece que há uma chave nessa gaveta, acho melhor pegá-la ! \n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.room_1;
        }
    }

    void state_sheets_0()
    {
        text.text = "Eu avisei para não confiar em estranhos, agora tente passar por esse desafio " +
                    "em pelo menos 10 minutos para que você não morra com a hemorragia em sua barriga !\n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.room_0;
        }
    }

    void state_door_0()
    {
        text.text = "Aparentemente essa porta está trancada.\nUrgh, que dor na barriga! \n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.room_0;
        }
    }

    void state_room_1()
    {
        text.text = "Bem, agora com essa chave talvez seja capaz de abrir algo que estava trancado. \n\n" +
                    "Pressione G para abrir a gaveta.\n" +
                    "Pressione P para ler os papéis.\n" +
                    "Pressione D para ir até a porta.\n";

        if (Input.GetKeyDown(KeyCode.G))
        {
            state = Estados.desk_1;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            state = Estados.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            state = Estados.corridor_0;
        }
    }

    void state_sheets_1()
    {
        text.text = "Eu avisei para não confiar em estranhos, agora tente passar por esse desafio " +
                    "em pelo menos 10 minutos para que você não morra com a hemorragia em sua barriga !\n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.room_1;
        }
    }
    
    void state_desk_1()
    {
        text.text = "Parece que não há mais nada aqui. \n\n" +
                    "Pressione R para retornar para a sala\n";
   
        if (Input.GetKeyDown(KeyCode.R))
        {
              state = Estados.room_1;
        }
    }

    void state_corridor_0()
    {
        text.text = "Opa, parece que agora estou em um corredor, e está bastante frio.. Brr !\n\n" +
                    "Pressione S para descer as escadas\n" +
                    "Pressione C para abrir o armário\n" +
                    "Pressione F para olhar o chão\n";

        if (Input.GetKeyDown(KeyCode.S))
        {
            state = Estados.stairs_0;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            state = Estados.closet_0;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            state = Estados.floor_0;
        }
    }

    void state_floor_0()
    {
        text.text = "Opa, parece que há um clips no chão, talvez ele me sirva mais tarde\n\n" +
                    "Pressione R para retornar para o corredor\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_1;
        }
    }

    void state_closet_0()
    {
        text.text = "Bem, parece que esse armário está trancado, como posso fazer para abri-lo ? \n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_0;
        }
    }

    void state_stairs_0()
    {
        text.text = "Está muito frio e estou só de cueca, não posso sair somente com essa roupa.. \n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_0;
        }
    }

    void state_corridor_1()
    {
        text.text = "Bem, agora tenho um clips, onde será que ele pode ser útil ?\n\n" +
                    "Pressione S para descer as escadas\n" +
                    "Pressione C para abrir o armário\n" +
                    "Pressione F para olhar o chão\n";

        if (Input.GetKeyDown(KeyCode.S))
        {
            state = Estados.stairs_1;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            state = Estados.closet_1;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            state = Estados.floor_1;
        }
    }

    void state_closet_1()
    {
        text.text = "Opa, parece que consigo abrir essa porta com esse clips \n\n" +
                    "Pressione O para abrir a porta\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_1;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            state = Estados.closet_2;
        }
    }

    void state_stairs_1()
    {
        text.text = "Está muito frio e estou só de cueca, não posso sair somente com essa roupa.. \n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_1;
        }
    }

    void state_floor_1()
    {
        text.text = "Bem, parece que não há mais nada no chão.. Urgh, preciso tomar cuidado ao me abaixar\n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_1;
        }
    }

    void state_closet_2()
    {
        text.text = "Bem, talvez essas roupas possam me proteger do frio.. \n\n" +
                    "Pressione V para Vestir as roupas\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_2;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            state = Estados.closet_3;
        }
    }

    void state_corridor_2()
    {
        text.text = "Está fazendo bastante frio, talvez seja melhor eu vestir aquelas roupas...\n\n" +
                    "Pressione S para descer as escadas\n" +
                    "Pressione C para abrir o armário\n" +
                    "Pressione F para olhar o chão\n";

        if (Input.GetKeyDown(KeyCode.S))
        {
            state = Estados.stairs_2;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            state = Estados.closet_2;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            state = Estados.floor_2;
        }
    }

    void state_stairs_2()
    {
        text.text = "Talvez com aquelas roupas de frio eu possa sair daqui...\n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_2;
        }
    }

    void state_floor_2()
    {
        text.text = "Bem, parece que não há mais nada no chão.. Urgh, preciso tomar cuidado ao me abaixar\n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_2;
        }
    }

    void state_floor_3()
    {
        text.text = "Bem, parece que não há mais nada no chão.. Urgh, preciso tomar cuidado ao me abaixar\n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_3;
        }
    }

    void state_closet_3()
    {
        text.text = "Agora estou bem agasalhado, com certeza posso ir lá fora ! \n\n" +
                    "Pressione R para retornar para a sala\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_3;
        }
    }

    void state_corridor_3()
    {
        text.text = "Acho que agora posso finalmente fugir daqui !!\n\n" +
                    "Pressione S para descer as escadas\n" +
                    "Pressione C para abrir o armário\n" +
                    "Pressione F para olhar o chão\n";

        if (Input.GetKeyDown(KeyCode.S))
        {
            state = Estados.stairs_3;
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            state = Estados.closet_3;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            state = Estados.floor_3;
        }
    }

    void state_stairs_3()
    {
        text.text = "Viva !! Acho que agora posso ir embora !!\n\n" +
                    "Pressione R para retornar para a sala\n" +
                    "Pressione L para deixar a casa\n";

        if (Input.GetKeyDown(KeyCode.R))
        {
            state = Estados.corridor_3;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            state = Estados.courtyard;
        }
    }

    void state_courtyard()
    {
        text.text = "Finalmente, agora posso sobreviver a esse frio, acho que devo " +
                    "procurar o médico mais próximo o mais rapido possivel..\n" +
                    "Por onde começo ?\n\n" +
                    "Pressione J para jogar novamente\n";

        if (Input.GetKeyDown(KeyCode.J))
        {
            state = Estados.start_game;
        }
    }
}
