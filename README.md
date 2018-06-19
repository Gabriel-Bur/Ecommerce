## Ecommerce Web Api .NET


## URL
http://localhost:XXXXX/api/Products

## Method:
|GET|POST|PUT|DELETE

## Return format
JSON is default

*JSON*
~/api/Products{?type=json}

*XML*
~/api/Products{?type=xml}

## URL Params
Optional:{ }


GET :
**~/api/Products/{id}**
**~/api/Products/{page}/{Number}**
        
POST:   
**~/api/Products**

PUT :
**~/api/Products/id**

DELETE: 
**~/api/Products/id**



## URL Filter
is CaseSensitive

?$filter=(Property) XX (Value)




Exemple:

~/api/Products?$filter=Category eq 'Doces'

```json
[
  {"Id":4,
  "Code":"00004",
  "Name":"Banana com Canela",
  "Description":"A mais saborosa do rio de janeiro",
  "Category":"Doces",
  "ImageURL":"https://media-cdn.tripadvisor.com/media/photo-s/0f/07/37/e2/pizza-banana-com-canela.jpg",
  "Price":9.80,
  "Brand":"Vezpa"
  },
  {"Id":6,
  "Code":"00005",
  "Name":"Chocolate",
  "Description":"A favorita da casa",
  "Category":"Doces",
  "ImageURL":"https://www.fileurbano.com.br/wp-content/uploads/2018/02/pizza-chocolate.jpg",
  "Price":9.80,
  "Brand":"Vezpa"}
]
```
## Filters Exemples:

![Odata uri table](https://github.com/Gabriel-Bur/Ecommerce/blob/master/1.jpg)
