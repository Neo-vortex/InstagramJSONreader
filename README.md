# InstagramJSONreader
With this library you can easily parse Instagram JSON files into .NET friendly Object

Depends  on Newtonsoft.json


how to use :

``` vb.net

Imports InstagramJSONreader.InstagramJsonReader
sub main()
Dim test As New InstagramJSONreader.InstagramJsonReader(URI)
Dim result As RootObject = test.GetInfo
MsgBox(result.users(0).user.Username)
end sub
```

The URI is like :
https://www.instagram.com/web/search/topsearch/?context=blended&query=XXXX&rank_token=XXXX
   
