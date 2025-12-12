// Last updated: 12/11/2025, 8:00:04 PM
public class BrowserHistory {
    List<string> Urls;
    int CurrentIndex = -1;
    public BrowserHistory(string homepage) {
        this.Urls = new List<string>();
        NavigateURL(homepage);
    }
    public void Visit(string url) {
        this.Urls.RemoveRange(this.CurrentIndex + 1, this.Urls.Count - 1 - this.CurrentIndex);
        NavigateURL(url);
    }
    private void NavigateURL(string url)
    {
        this.Urls.Add(url);
        this.CurrentIndex++;
    }
    public string Back(int steps) {
        this.CurrentIndex = Math.Max(0, this.CurrentIndex - steps);
        return this.Urls[this.CurrentIndex];
    }
    
    public string Forward(int steps) {
        this.CurrentIndex = Math.Min(this.Urls.Count -1, this.CurrentIndex + steps);
        return this.Urls[this.CurrentIndex];
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */