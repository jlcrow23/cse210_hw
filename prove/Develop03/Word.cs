public class Word
{
    private string _text;
    private bool _isHidden;
    public bool IsHidden()
    {
        get 
        {
            return _isHidden;
        }
        set 
        {
            if 
            {
                _isHidden = hidden;
            } 
            else 
            {
                return false;
            }

        }
    }
    public void Hide()
    {
        get 
        {
            return _isHidden;
        }
        set
        {
            _isHidden = hidden;
        }
    }
    public void Show()
    {
        hidden = false;
    }
    public Word (string text, bool IsHidden)
    {
        _text = text;
        _isHidden = false;
    }
    
    public bool IsHidden()
    {
        return true;
    }
    public string GetDisplayText()
    {
        return "hi";
    }
}
