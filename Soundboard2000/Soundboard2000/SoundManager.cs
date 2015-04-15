using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace Soundboard2000
{
    static class SoundManager
    {
        public static int SoundStream;

        public static void Init()
        {
            InitAudio();
        }

        public static void PlaySound(string path)
        {
            SoundStream = Bass.BASS_StreamCreateFile(path, 0, 0, BASSFlag.BASS_DEFAULT);
            if (SoundStream != 0)
                Bass.BASS_ChannelPlay(SoundStream, false);
        }

        static void InitAudio()
        {
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
        }
    }
}
