/// <reference path="c:\users\ram\documents\visual studio 2015\Projects\EventsDemo\Scripts/backbone.js" />

var EventView = Backbone.View.extend({
    el: '#resultDiv',
    initialize: function () {

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
    eventDetails: function () {
        var source = $("#event_details").html();
        var template = Handlebars.compile(source);
        var eventModel = new EventModel();
        var self = this;
        eventModel.fetch({
            success: function (response) {
                var data = response.toJSON();
                _.each(data, function (event, index) {
                    var html = template(event);
                    self.$el.append(html)
                })
            }
        })
    }
});