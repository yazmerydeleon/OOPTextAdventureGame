using OOPTextAdventureGame;

public class Spanish : Language
{
    public Spanish()
    {
        ChooseYourName = "Hola, ¿Cuál es tu nombre? ";
        DefaultName = "No Nombre";
        Welcome = "Bienvenid@ {0} to OOP Adventure!";
        DefaultRoomName = "Habitación {0} ({1},{2})";
        DefaultRoomDescription = "Estas en una habitación con puertas a {0}. ";
        ActionError = "No puedes hacer eso.";
        Go = "Ve";
        GoError= "No puedes ir por este lado";
        WhatToDo = "¿Qué quieres hacer?";
        Quit= "salir";

    }
}
