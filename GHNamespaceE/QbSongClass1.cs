using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using GHNamespace6;
using GHNamespace9;

namespace GHNamespaceE
{
    public static class QbSongClass1
    {
        private static readonly Dictionary<int, string> KeyDict1 = new Dictionary<int, string>();

        private static readonly Dictionary<int, string> KeyDict2 = new Dictionary<int, string>();

        public static bool Dirty; //This hasn't been saved yet?..

        public static void smethod_0()
        {
            if (Dirty)
            {
                return;
            }
            AddAllLinesToDictionary(new MemoryStream(
                ZipManager.smethod_5(
                    KeyGenerator.CryptoMethod(
                        Assembly.GetExecutingAssembly()
                            .GetManifestResourceStream("NeversoftTools.NSTreeView.nstags.aes"), "MinimizedNSTags1245"),
                    "nstags.ids")));
            Dirty = true;
        }

        public static void AddAllLinesToDictionary(Stream stream, bool useSecondDictionary = false)
        {
            using (StreamReader streamReader = new StreamReader(stream))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    if (!text.Equals(""))
                    {
                        int key = KeyGenerator.GetQbKey(text, true);
                        if (!KeyDict1.ContainsKey(key) && !KeyDict2.ContainsKey(key))
                        {
                            if (useSecondDictionary)
                            {
                                KeyDict2.Add(key, text);
                            }
                            else
                            {
                                KeyDict1.Add(key, text);
                            }
                        }
                    }
                }
            }
        }

        public static bool ContainsKey(int key)
        {
            return KeyDict1.ContainsKey(key) || KeyDict2.ContainsKey(key);
        }

        public static bool smethod_4(string string0)
        {
            return KeyDict1.ContainsValue(string0.ToLower());
        }

        public static string GetDictString(int key)
        {
            if (KeyDict1.ContainsKey(key))
            {
                return KeyDict1[key];
            }
            if (KeyDict2.ContainsKey(key))
            {
                return KeyDict2[key];
            }
            return null;
        }

        public static int smethod_6(string string0)
        {
            if (!(string0 == ""))
            {
                return KeyGenerator.GetQbKey(Encoding.Unicode.GetBytes(string0), true);
            }
            return 0;
        }

        public static void AddStringToDictionary(string str, bool addToTheOtherDictionaryToo = true)
        {
            if (KeyDict1.ContainsValue(str) || KeyDict2.ContainsValue(str))
            {
                return;
            }
            int key = KeyGenerator.GetQbKey(str, true);
            if (addToTheOtherDictionaryToo && !KeyDict2.ContainsKey(key))
            {
                KeyDict2.Add(key, str);
                return;
            }
            if (!KeyDict1.ContainsKey(key))
            {
                KeyDict1.Add(key, str);
            }
        }

        public static int AddKeyToDictionary(string qbName)
        {
            qbName = qbName.ToLower();
            int key = KeyGenerator.GetQbKey(qbName, true);
            if (!ContainsKey(key))
            {
                KeyDict2.Add(key, qbName);
            }
            return key;
        }

        public static void GenerateSongTrackStuff(string songName)
        {
            AddStringToDictionary(songName);
            string[] singerTypes =
            {
                "_male_",
                "_female_"
            };
            for (int i = 0; i < singerTypes.Length; i++)
            {
                string singerGender = singerTypes[i];
                for (int j = 1; j < 10; j++)
                {
                    AddStringToDictionary(string.Concat("gh3_singer", singerGender, songName, "_", j));
                    AddStringToDictionary(string.Concat("gh3_singer", singerGender, songName, "_", j, "b"));
                }
            }
            AddStringToDictionary("animload_singer_male_" + songName);
            AddStringToDictionary("animload_singer_female_" + songName);
            AddStringToDictionary("menu_music_" + songName);
            AddStringToDictionary("songs\\" + songName + ".mid.qb");
            AddStringToDictionary("songs\\" + songName + ".mid.qs");
            AddStringToDictionary("songs\\" + songName + ".mid_text.qb");
            AddStringToDictionary("songs\\" + songName + "_song_scripts.qb");
            AddStringToDictionary("data\\songs\\" + songName + ".mid");
            AddStringToDictionary("data\\songs\\" + songName + ".mid_text");
            AddStringToDictionary("data\\songs\\" + songName + "_song_scripts.qb");
            AddStringToDictionary("dlc\\output\\" + songName + ".mid.qb");
            AddStringToDictionary("dlc\\output\\" + songName + ".mid_text.qb");
            AddStringToDictionary("dlc\\output\\" + songName + ".mid");
            AddStringToDictionary("dlc\\output\\" + songName + ".mid_text");
            AddStringToDictionary("dlc\\output\\" + songName + "_song_scripts.qb");
            string[] array2 =
            {
                "",
                "rhythm_",
                "guitarcoop_",
                "rhythmcoop_",
                "drum_",
                "aux_"
            };
            for (int k = 0; k < array2.Length; k++)
            {
                string text2 = array2[k];
                string[] array3 =
                {
                    "easy",
                    "medium",
                    "hard",
                    "expert"
                };
                for (int l = 0; l < array3.Length; l++)
                {
                    string text3 = array3[l];
                    AddStringToDictionary(songName + "_song_" + text2 + text3);
                    AddStringToDictionary(string.Concat(songName, "_", text2, text3, "_star"));
                    AddStringToDictionary(string.Concat(songName, "_", text2, text3, "_starbattlemode"));
                    AddStringToDictionary(string.Concat(songName, "_", text2, text3, "_tapping"));
                    AddStringToDictionary(string.Concat(songName, "_", text2, text3, "_whammycontroller"));
                }
                AddStringToDictionary(songName + "_" + text2 + "faceoffstar");
                AddStringToDictionary(songName + "_" + text2 + "faceoffp1");
                AddStringToDictionary(songName + "_" + text2 + "faceoffp2");
            }
            AddStringToDictionary(songName + "_bossbattlep1");
            AddStringToDictionary(songName + "_bossbattlep2");
            AddStringToDictionary(songName + "_timesig");
            AddStringToDictionary(songName + "_fretbars");
            AddStringToDictionary(songName + "_guitar_markers");
            AddStringToDictionary(songName + "_rhythm_markers");
            AddStringToDictionary(songName + "_drum_markers");
            AddStringToDictionary(songName + "_vocals_markers");
            AddStringToDictionary(songName + "_easy_drumfill");
            AddStringToDictionary(songName + "_medium_drumfill");
            AddStringToDictionary(songName + "_hard_drumfill");
            AddStringToDictionary(songName + "_expert_drumfill");
            AddStringToDictionary(songName + "_easy_drumunmute");
            AddStringToDictionary(songName + "_medium_drumunmute");
            AddStringToDictionary(songName + "_hard_drumunmute");
            AddStringToDictionary(songName + "_expert_drumunmute");
            AddStringToDictionary(songName + "_song_vocals");
            AddStringToDictionary(songName + "_vocals_freeform");
            AddStringToDictionary(songName + "_vocals_phrases");
            AddStringToDictionary(songName + "_vocals_note_range");
            AddStringToDictionary(songName + "_lyrics");
            AddStringToDictionary(songName + "_scripts_notes");
            AddStringToDictionary(songName + "_anim_notes");
            AddStringToDictionary(songName + "_triggers_notes");
            AddStringToDictionary(songName + "_cameras_notes");
            AddStringToDictionary(songName + "_lightshow_notes");
            AddStringToDictionary(songName + "_crowd_notes");
            AddStringToDictionary(songName + "_drums_notes");
            AddStringToDictionary(songName + "_performance_notes");
            AddStringToDictionary(songName + "_scripts");
            AddStringToDictionary(songName + "_anim");
            AddStringToDictionary(songName + "_triggers");
            AddStringToDictionary(songName + "_cameras");
            AddStringToDictionary(songName + "_lightshow");
            AddStringToDictionary(songName + "_crowd");
            AddStringToDictionary(songName + "_drums");
            AddStringToDictionary(songName + "_performance");
        }
    }
}