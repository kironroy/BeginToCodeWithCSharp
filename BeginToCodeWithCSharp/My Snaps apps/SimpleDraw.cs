using SnapsLibrary;

class SimpleDraw
{
    public void StartProgram()
    {
        while (true)
        {
            SnapsEngine.SetDrawingColor(red: 255, green: 0, blue: 0);
            SnapsCoordinate drawPos = SnapsEngine.GetDraggedCoordinate();
            SnapsEngine.DrawDot(pos: drawPos, width: 10);
        }
    }
}