namespace lesson5._5
{
    
    public class ToDo
    {
        private string _title;
        private bool _isDone;

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public bool IsDone
        {
            get => _isDone;
            set => _isDone = value;
        }
    }
}
