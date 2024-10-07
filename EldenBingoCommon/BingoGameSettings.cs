namespace ObidoBingoCommon
{
    public record struct BingoGameSettings(int BoardSize, int CategoryLimit, int RandomSeed, int PreparationTime, int PointsPerBingoLine);
}