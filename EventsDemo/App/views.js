/// <reference path="c:\users\ram\documents\visual studio 2015\Projects\EventsDemo\Scripts/backbone.js" />
var AppRouter = Backbone.Router.extend({
    routes: {
        "event/:id": "getPost",
        "*actions": "defaultRoute"
    }
});

var appRoute = new AppRouter();
appRoute.on('route:getpost', function(id) {
    alert(id);
})

var EventView = Backbone.View.extend({
    el: '#resultDiv',
    initialize: function () {

    },
    events:{
        'click #evetnName': 'eventDetails'
    },
    render: function () {
        var source = $("#events_template").html();
        var template = Handlebars.compile(source);
        var eventModel = new EventModel();
        var self = this;
        eventModel.fetch({
            success: function (response) {
                var data = response.toJSON();
                _.each(data, function (event, index) {
                    var html = template(event);
                    self.$el.append(html)
                });
            }
        });
        return this;
    },
    eventDetails: function (e) {
        var currentEventId = $(e.currentTarget).attr('data-value');
        var source = $("#event_details").html();
        var template = Handlebars.compile(source);
        var eventModel = new EventModel();
        var self = this;
        eventModel.fetch({
            success: function (response) {
                var data = response.toJSON();
                _.each(data, function (event, index) {
                    if (event.id == currentEventId) {
                        var html = template(event);
                        self.$el.html(html)
                    }
                })
            }
        })
    },
    eventDeatils: function (id) {
        var self = this;
        eventModel.fetch({
            success: function (response) {
                var data = response.toJSON();
                _.each(data, function (event, index) {
                    if (event.id == id) {
                        var html = template(event);
                        self.$el.html(html);
                    }
                })
            }
        })
    }
});