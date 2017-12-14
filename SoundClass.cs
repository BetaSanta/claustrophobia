using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace claustrophobia
{
    static class SoundClass
    {
        public static SoundPlayer sound_background = new SoundPlayer(Properties.Resources.background);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);
        public static bool sound_enabled = true;

        public static void sound_on()
        {
            sound_enabled = true;
        }

        public static void sound_off()
        {
            sound_enabled = false;
        }

        public static void PlayBackground()
        {
            if (sound_enabled) 
                sound_background.PlayLooping();
        }

        public static void PlayStart()
        {
            if (sound_enabled)
                sound_start.Play();
        }
    }
}
