# trusTech

### /api/news :

This endpoint allows you to find the top headlines and breaking news.

### /api/news/search/"gitty" :

//gitty is an example of a search keyword
1. You cannot use other characters than alphabetic characters outside of quotes context.
 
2. To use the phrase search operator surrounds your phrase with quotes like so "Apple iPhone".

3. Operator NOT
To use the NOT operator add this NOT  before each word or phrase (e.g. Apple AND NOT iPhone). Articles that contain the word iPhone will be removed from the results.

4. Operator AND
There are two ways to use the AND operator.
Add this  AND  between each word or phrase (e.g. Apple AND Microsoft)
Add a space between each word or phrase (e.g. Apple Microsoft).

5. Operator OR
First of all, note that the operator OR has a higher precedence than the operator AND. To use the OR operator add this  OR  between each word or phrase (e.g. Apple OR Microsoft).

This endpoint allows you to search articles from keywords.

### /api/new/max/1 : 

//1 is an example of a maximum number of articles returned

Set the maximum number of articles returned per request. 100 is the maximum value.
