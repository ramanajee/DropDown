/// <reference path="c:\Users\Ram\Documents\Visual Studio 2015\Projects\VenueWeb\Scripts/underscore.js" />
/// <reference path="c:\Users\Ram\Documents\Visual Studio 2015\Projects\VenueWeb\Scripts/backbone.js" />

var EventModel = Backbone.Model.extend({
    urlRoot: "DAL/data.json",
    initialize: function() {
        console.log("Hello World");
    }
});