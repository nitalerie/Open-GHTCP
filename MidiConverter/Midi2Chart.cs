﻿using System;
using System.IO;
using System.Windows.Forms;
using GHNamespace8;
using GHNamespaceN;
using mid2chart;

namespace MidiConverter
{
    class Midi2Chart
    {
        public static QbcParser LoadMidiSong(string fileName, bool forceRb3)
        {
            QbcParser qbc = null;
            Song song = null;
            try
            {
                song = MidReader.ReadMidi(fileName);
                string chartFile = ChartWriter.writeChart(song, "", false, forceRb3).ToString();
                ChartParser chartParser = new ChartParser(chartFile, false);
                chartParser.Gh3SongInfo = IniParser.ParseIni(Path.GetDirectoryName(fileName), chartParser.Gh3SongInfo);
                qbc = chartParser.ConvertToQbc();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error using the new MIDI importer.\nReverting to original GHTCP method. \n\n" + e,
                    "MIDI Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                qbc = new MidiParser(fileName).LoadMidi().ConvertToQbc();
            }
            return qbc;
        }
    }
}