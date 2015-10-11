/// <reference path="c:\Users\Ram\Documents\Visual Studio 2015\Projects\VenueWeb\Scripts/underscore.js" />
/// <reference path="c:\Users\Ram\Documents\Visual Studio 2015\Projects\VenueWeb\Scripts/backbone.js" />
/// <reference path="c:\Users\Ram\Documents\Visual Studio 2015\Projects\VenueWeb\Scripts/handlebars-v4.0.2.js" />

var EventView = Backbone.View.extend({
    el:'body',
    initialize: function() {
        console.log("EventsView");
    },
    render: function () {
        var source = $("#events_template").html();
        var template = Handlebars.compile(source);
        var eventModel = new EventModel();
        var self = this;
        eventModel.fetch({
            success: function (response) {
                var data = response.toJSON();
                _.each(data, function (event) {
                    var html = template(event);
                    self.$el.append(html)
                })
            }
        })
        
        return this;
    }
});
