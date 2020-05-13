using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.IO;
using NAudio.Lame;

namespace AutoTheVoice
{
    public class mashup
    {
        public static string CreateMashup(string[] files,string outpath)
        {
            // because there is no mash up with less than 2 files
            if (files.Count() < 2)
            {
                throw new Exception("Not enough files selected!");
            }

            try
            {
                // Create a mixer object
                // This will be used for merging files together
                var mixer = new WaveMixerStream32
                {
                    AutoStop = true
                };

                // Set the path to store the mashed up output file
                var outputFile = outpath;

                foreach (var file in files)
                {
                    // for each file -
                    // check if it exists in the temp folder
                    var filePath = file;
                    if (File.Exists(filePath))
                    {
                        // create mp3 reader object
                        var reader = new Mp3FileReader(filePath);

                        // create a wave stream and a channel object
                        var waveStream = WaveFormatConversionStream.CreatePcmStream(reader);
                        var channel = new WaveChannel32(waveStream)
                        {
                            //Set the volume
                            Volume = 0.5f
                        };

                        // add channel as an input stream to the mixer
                        mixer.AddInputStream(channel);
                    }
                }

                // convert wave stream from mixer to mp3
                var wave32 = new Wave32To16Stream(mixer);
                var mp3Writer = new LameMP3FileWriter(outputFile, wave32.WaveFormat, 128);
                wave32.CopyTo(mp3Writer);

                // close all streams
                wave32.Close();
                mp3Writer.Close();

                // return the mashed up file path
                return outputFile;
            }
            catch (Exception)
            {
                // TODO: handle exception
                throw;
            }
        }
    }
}
