var Viewmodel = function () {
    var self = this;
    self.movies = ko.observableArray();
    self.error = ko.observable();

    var moviesUri = "/api/movies";
    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllMovies() {
        ajaxHelper(moviesUri, 'GET').done(function (data) {
            self.movies(data);
        });
    }

    // Fetch the initial data.
    getAllMovies();
}

ko.applyBindings(new ViewModel());