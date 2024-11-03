﻿using ObidoBingoCommon;

namespace ObidoBingo.Settings
{
    internal static class GameSettingsHelper
    {
        internal static BingoGameSettings ReadFromSettings(Properties.Settings settings)
        {
            var classes = new HashSet<EldenRingClasses>();
            try
            {
                foreach (var classNumber in settings.GS_Classes.Split(","))
                {
                    if (int.TryParse(classNumber, out int val))
                    {
                        classes.Add((EldenRingClasses)val);
                    }
                }
            }
            catch
            {
                foreach (EldenRingClasses cl in Enum.GetValues(typeof(EldenRingClasses)))
                {
                    classes.Add(cl);
                }
            }
            var gameSettings = new BingoGameSettings(
                settings.GS_BoardSize,
                settings.GS_CategoryLimit,
                settings.GS_RandomSeed,
                settings.GS_PreparationTime,
                settings.GS_BonusPerBingo,
                settings.GS_RequiredSquares);

            return gameSettings;
        }

        internal static void SaveToSettings(BingoGameSettings gameSettings, Properties.Settings settings)
        {
            settings.GS_BoardSize = gameSettings.BoardSize;
            settings.GS_CategoryLimit = gameSettings.CategoryLimit;
            settings.GS_RandomSeed = gameSettings.RandomSeed;
            settings.GS_PreparationTime = gameSettings.PreparationTime;
            settings.GS_BonusPerBingo = gameSettings.PointsPerBingoLine;
            settings.GS_RequiredSquares = gameSettings.RequiredSquares;
            settings.Save();
        }
    }
}