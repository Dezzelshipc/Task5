namespace Task5
{
    class PopcornPopper
    {
        public void on()
        {
            Console.WriteLine("Start coocking popcorn");
        }

        public void off()
        {
            Console.WriteLine("Stop coocking popcorn");
        }

        public void pop()
        {
            Console.WriteLine("You're popping popcorn");
        }
    }

    class Screen
    {
        public void up()
        {
            Console.WriteLine("The screen went up");
        }

        public void down()
        {
            Console.WriteLine("The screen went down");
        }
    }

    class TheaterLights
    {
        public void on()
        {
            Console.WriteLine("Theater lights are on");
        }

        public void off()
        {
            Console.WriteLine("Theater lights are off");
        }

        public void dim()
        {
            Console.WriteLine("Theater lights are dim");
        }
    }

    class Tuner
    {
        Amplifier amplifier;

        public Tuner(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void on()
        {
            Console.WriteLine("Tuner is on");
            amplifier.on();
        }

        public void off()
        {
            Console.WriteLine("Tuner is off");
            amplifier.off();
        }

        public void setAm()
        {
            Console.WriteLine("Tuner is set to AM");
        }

        public void setFm()
        {
            Console.WriteLine("Tuner is set to FM");
        }
    }

    class DvdPlayer
    {
        Amplifier amplifier;

        public DvdPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void on()
        {
            Console.WriteLine("Dvd player is on");
            amplifier.on();
        }

        public void off()
        {
            Console.WriteLine("Dvd player is off");
            amplifier.off();
        }

        public void play()
        {
            Console.WriteLine("Dvd player is playing");
        }

        public void setDvd()
        {
            Console.WriteLine("Dvd is set to Dvd player");
        }

        public void pause()
        {
            Console.WriteLine("Dvd player is paused");
        }
    }

    class CdPlayer
    {
        Amplifier amplifier;

        public CdPlayer(Amplifier amplifier)
        {
            this.amplifier = amplifier;
        }

        public void on()
        {
            Console.WriteLine("Cd player is on");
            amplifier.on();
        }

        public void off()
        {
            Console.WriteLine("Cd player is off");
            amplifier.off();
        }

        public void play()
        {
            Console.WriteLine("Cd player is playing");
        }

        public void pause()
        {
            Console.WriteLine("Cd player is paused");
        }
    }

    class Amplifier
    {
        int volume = 0;
        public void on()
        {
            if (volume == 0)
            {
                Console.WriteLine("Amplifier is on");
                volume = 1;
            }
        }

        public void off()
        {
            if (volume > 0)
            {
                Console.WriteLine("Amplifier is off");
                volume = 0;
            }
        }

        public void setVolume(int vol)
        {
            Console.WriteLine("Amplifier has changed volume");
            volume = vol;
        }
    }

    class Projector
    {
        DvdPlayer dvdPlayer;

        public Projector(DvdPlayer dvdPlayer)
        {
            this.dvdPlayer = dvdPlayer;
        }

        public void on()
        {
            Console.WriteLine("Projector is on");
            dvdPlayer.on();
        }

        public void off()
        {
            Console.WriteLine("Projector is off");
            dvdPlayer.off();
        }
    }

    class HomeTheaterFacade
    {
        Amplifier amplifier;
        CdPlayer cdPlayer;
        DvdPlayer dvdPlayer;
        PopcornPopper popcornPopper;
        Tuner tuner;
        TheaterLights theaterLights;
        Screen screen;
        Projector projector;

        public HomeTheaterFacade(Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer, PopcornPopper popcornPopper, Tuner tuner, TheaterLights theaterLights, Screen screen, Projector projector)
        {
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.tuner = tuner;
            this.theaterLights = theaterLights;
            this.screen = screen;
            this.projector = projector;
        }
        public void watchMovie()
        {
            theaterLights.dim();
            popcornPopper.on();
            screen.down();
            projector.on();
        }

        public void endMovie()
        {
            projector.off();
            screen.up();
            popcornPopper.off();
            theaterLights.off();
        }

        public void listenToCd()
        {
            cdPlayer.on();
        }

        public void endCd()
        {
            cdPlayer.off();
        }

        public void listenToRadio()
        {
            tuner.on();
        }

        public void endRadio()
        {
            tuner.off();
        }
    }

    class Program {
        public static int Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amplifier);
            DvdPlayer dvdPlayer = new DvdPlayer(amplifier);
            PopcornPopper popcornPopper = new PopcornPopper();
            Tuner tuner = new Tuner(amplifier);
            TheaterLights theaterLights = new TheaterLights();
            Screen screen = new Screen();
            Projector projector = new Projector(dvdPlayer);

            HomeTheaterFacade facade = new HomeTheaterFacade(amplifier, cdPlayer, dvdPlayer, popcornPopper, tuner, theaterLights, screen, projector);
            facade.watchMovie();
            Console.WriteLine("\nYou're watching movie \n");
            facade.endMovie();
            Console.WriteLine("\n");
            facade.listenToRadio();

            return 0;
        }
    }
}