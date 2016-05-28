var app = angular.module("PostApp", []);

app.controller("PostController", function ($http) {

    var self = this;

    self.posts = [

    ];

    self.getPosts = function () {
        $http.get("/api/Post")
            .then(function (response) {
                for (var i = 0; i < response.data.length; i++) {
                    self.posts.push(response.data[i]);
                }
                
            })
    }

    /*self.getPosts() <- returns result of calling of getPosts */
    /*self.getPosts <- reference to function */
    self.getPosts();
    setInterval(self.getPosts,10000);

    /* (function(){})(); */


});