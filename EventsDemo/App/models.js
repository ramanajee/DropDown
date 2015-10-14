/// <reference path="c:\users\ram\documents\visual studio 2015\Projects\EventsDemo\Scripts/backbone.js" />


var EventModel = Backbone.Model.extend({
    urlRoot: "DAL/data.json",
    initialize: function () {
    }
});

var EventDetails = Backbone.Model.extend({
    urlRoot:''
})