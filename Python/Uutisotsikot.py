import feedparser

NewsFeed = feedparser.parse("https://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss")

print("Uutisotsikoita yhteensä:", len(NewsFeed.entries))

lkm = 0
for i in NewsFeed.entries:
    print(i.title)
    lkm += 1
    if lkm > 5:
        break
