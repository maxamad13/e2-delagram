var app = angular.module("PostApp", []);

app.controller("PostController", function ($http) {

    var self = this;

    self.posts = [

    ];

    var timenow = Date.now(); // UTC Time tho

    self.getPosts = function () {
        $http.get("/api/Post")
            .then(function (response) {
                for (var i = 0; i < response.data.length; i++) {
                    var posttime = new Date(response.data[i]['Time']);
                    var post = response.data[i];
                    var timediff = timenow - posttime;

                    if (timediff < 1000) {
                        post['Time'] = 'right now';
                    } else if (timediff >= 1000 && timediff < 60000) {
                        post['Time'] = Math.floor(timediff/1000) + " s ago";
                    } else if (timediff >= 60000 && timediff < 3600000) {
                        post['Time'] = Math.floor(timediff / 60000) + " min ago";
                    } else if (timediff >= 3600000) {
                        post['Time'] = Math.floor(timediff / 3600000) + " h ago";
                    }

                    self.posts.push(post);
                }
                
            })
    }

    /*self.getPosts() <- returns result of calling of getPosts */
    /*self.getPosts <- reference to function */
    self.getPosts();
    setInterval(self.getPosts,10000);

    /* (function(){})(); */


});