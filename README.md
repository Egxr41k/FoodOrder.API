# FoodOrder [API schema]

**Auth**

auth by asp net Identity

**Organizations**

[GET] [Authorize(Roles = "User")] Organization () => ()

[GET] [] Organization () => ()

[GET] [Authorize(Roles = "Admin")] Organization () => ()

[POST] [Authorize(Roles = "Admin")] Organization/Create () => ()

[POST] [Authorize(Roles = "Admin")] Organization/Edit/id () => ()

[POST] [Authorize(Roles = "Admin")] Organization/Delete/id () => ()

**Dish** 

[GET] [Authorize(Roles = "Admin")] Dish?OrganizationId=id () => ()

[GET] [] Dish/IndexAll?OrganizationId=id () => ()

[POST] [Authorize(Roles = "Admin")] Dish/Create?organizationId=id () => ()

[POST] [Authorize(Roles = "Admin")] Dishes/Edit/id () => ()

[POST] [Authorize(Roles = "Admin")] Dishes/Delete/id () => ()

**Basket**

[GET] [Authorize(Roles = "User")] Busket () => ()

[POST] [Authorize(Roles = "User")] Busket/CreateOrEdit/id () => ()

[POST] [Authorize(Roles = "User")] Busket/Pay/id () => ()

[POST] [Authorize(Roles = "User")] Busket/RatingAndComment/id () => ()

[POST] [Authorize(Roles = "User")] Busket/Delete/id () => ()

