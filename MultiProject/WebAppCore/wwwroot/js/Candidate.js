const { param } = require("jquery");

function CandidateLogLoad(passTheme, passSitepath, extras) {
    var parameter = {
        gridName: "candidateLog",
        viewName: "Candidate_LOOKUP",
        browseCode: "CandidateLog",
        toolbarName: "CandidateToolbar",
        viewController: "Candidates",
        requestSrc: "Candidate"
    };
    GridLogLoad(passTheme, passSitepath, extras, parametersq )
}

//CONVERT CANDIDATE TO EMPLOYEE
function convertToEmployee(candId) {
    var successFunction = function (result) {
        if (candId) {
            return;
        }
    };
}