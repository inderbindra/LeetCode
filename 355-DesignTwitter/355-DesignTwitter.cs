// Last updated: 12/11/2025, 8:01:47 PM

public class Twitter {

    Dictionary<int, long> Tweets;
    Dictionary<int, HashSet<(int tweetId, int userId)>> UserTweets;
    Dictionary<int, HashSet<int>> UserFollowers;
    const int maxTweets = 10;
    public Twitter() {
        Tweets = new();
        UserTweets = new();
        UserFollowers = new();
    }
    
    public void PostTweet(int userId, int tweetId) {
        long ticks = DateTime.Now.Ticks;
        Tweets.Add(tweetId, ticks);
        UserTweets.TryAdd(userId, new HashSet<(int, int)>());
        UserTweets[userId].Add((tweetId, userId));

        if(UserFollowers.ContainsKey(userId))
        {
            foreach(var followerId in UserFollowers[userId])
            {
                UserTweets.TryAdd(followerId, new HashSet<(int tweetId, int userId)>());
                UserTweets[followerId].Add((tweetId, userId));
            }
        }
    }
    
    public IList<int> GetNewsFeed(int userId) 
    {
        IList<int> tweets = new List<int>();
        PriorityQueue<int, long> pq = new();
        if(UserTweets.ContainsKey(userId))
        {
            foreach(var tweet in UserTweets[userId])
            {
                pq.Enqueue(tweet.tweetId, -Tweets[tweet.tweetId]);
            }
            int i=0;
            while(i < maxTweets && pq.Count > 0)
            {
                tweets.Add(pq.Dequeue());
                i++;
            }
        } 
        return tweets;      
    }
    
    public void Follow(int followerId, int followeeId) 
    {
        UserFollowers.TryAdd(followeeId, new HashSet<int>());
        UserFollowers[followeeId].Add(followerId);

        if(UserTweets.ContainsKey(followeeId))
        {
            UserTweets.TryAdd(followerId, new HashSet<(int tweetId, int userId)>());
            foreach(var tweet in UserTweets[followeeId])
            {
                if(tweet.userId == followeeId)
                {
                    UserTweets[followerId].Add((tweet.tweetId, followeeId));
                }
            }
        }
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(UserFollowers.ContainsKey(followeeId))
        {
            UserFollowers[followeeId].Remove(followerId);
            if(UserTweets.ContainsKey(followeeId))
            {
                foreach(var tweet in UserTweets[followeeId])
                {
                    if(tweet.userId == followeeId)
                    {
                        UserTweets[followerId].Remove(tweet);
                    }
                    
                }
            }
        }
        
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */