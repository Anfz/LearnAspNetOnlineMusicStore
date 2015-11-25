"use strict";
class Report {

    constructor(model, definition) {

    };


    display() {
        $('.report').append("<p>Using Javascript To Build HTML cause ummm not playing with angular yet?</p>" +
            "<p> " +@Html.DisplayNameFor(model => model.Album.Title) );
    }


}

// only for one report should really look though and define them all 



var report = new Report();
report.display();