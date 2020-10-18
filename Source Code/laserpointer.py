import cv2
import numpy as np
import autopy

cap = cv2.VideoCapture(0)

clickonce = 0

pts = []

while True:
    # Take each frame
    ret, frame = cap.read()

    hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV)

    # Finds laser pointer
    lower_red = np.array([0, 0, 255])
    upper_red = np.array([100, 100, 255])
    mask = cv2.inRange(hsv, lower_red, upper_red)
    (minVal, maxVal, minLoc, maxLoc) = cv2.minMaxLoc(mask)

    # Show circle around laser and show other views
    cv2.circle(frame, maxLoc, 20, (0, 0, 255), 2, cv2.LINE_AA)
    cv2.imshow('Track Laser', frame)
    # cv2.imshow("Mask", mask)
    # cv2.imshow("HSV", hsv)

    # Turn maxLoc array into the x and y coordinates of laser
    x = maxLoc[0]
    y = maxLoc[1]

    # Prints x and y positions
    print(x)
    print(y)

    # Moves mouse to position
    if y < 360 and x < 750:
        autopy.mouse.move(x * 3, y * 3)

    # Clicks, but only once
    if y == 0 and x == 0 and clickonce == 0:
        clickonce = 1
        autopy.mouse.click()
        print("Click!")
    elif y == 0 and x == 0 and clickonce == 1:
        None
    else:
        clickonce = 0

    # Failsafe
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

# Destroys all windows
cap.release()
cv2.destroyAllWindows()