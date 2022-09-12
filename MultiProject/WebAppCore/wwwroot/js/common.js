const { auto } = require("@popperjs/core");

function WaitWindow(message, template, timeout, container) {
    var autoClose = true;
    template = template || 'info';

    if (timeout == null)
        timeout = 5000;

    if (timeout == -1) {
        timeout = 1;
        autoClose = false;
    }

    var closeOnClick = autoClose;

    if (timeout == -2) {
        timeout = 1;
        autoClose = false;
        closeOnClick = true;
    }

    var notification = document.createElement('div');
    notification.style.display = 'none';
    notification.innerHTML = "<div>" + message + "</div>";
    var jqNotification = $(notification);
    document.body.appendChild(notification);
    jqNotification.jqxNotification({
        position: 'top-right', opacity: 1, autoOpen: false, animationOpenDelay: 800, autoClose, autoCloseDelay: timeout,
        animationCloseDelay: 800, template: template, browserBoundsOffset: 60, closeOnClick: closeOnClick
    });

    var topPixels = "40";
    var containerName = replaceAll(container, "#", "");

    if (container == null) {
        containerName = "";
        container = ".actual-html-page";
        topPixels = "60";
    }

    var notificationId = "myNotificationsBox" + (Math.floor(Math.random() * 12000) + 1);

    if (container != null) {
        $(container).append("<div style='positioin: absolute; top: " + topPixels + "px; right: 10 px; z-index: 9999;' class'" + notificationId + "' id='myNotificationBox" + containerName + "'></div>");
        jqNotification.jqxNotification({ appendContainer: "#myNotificationBox" + containerName });
    }

    jqNotification.jqxNotification('open');
    jqNotification.on('close', function () {
        document.body.removeChild(notification);
    });
}