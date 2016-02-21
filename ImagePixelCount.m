function [numberOfBlackPixel] = ImagePixelCount(a,b) 

%Capture image from IP cameras 
% urlPEnd1 = 'http://192.168.1.4:8080/shot.jpg';
% urlPEnd2 = 'http://192.168.1.3:8080/shot.jpg';

%Read captured images
image1  = imread(a);
image2  = imread(b);

%Converting images into GrayScale
grayImage1 = rgb2gray(image1);
grayImage2 = rgb2gray(image2);

[rows1, columns1] = size(grayImage1);
[rows2, columns2] = size(grayImage2);

binaryImage1 = grayImage1 > 150;
binaryImage2 = grayImage2 > 150;
subplot(2, 2, 1);
imshow(binaryImage1, []);
subplot(2, 2, 2);
imshow(binaryImage2, []);

numberOfBlackPixels1 = sum(sum(binaryImage1 == 0));
totalNumberOfPixels1 = rows1 * columns1;
percentBlackPixels1 = 100.0 * numberOfBlackPixels1 /totalNumberOfPixels1;

numberOfBlackPixels2 = sum(sum(binaryImage2 == 0));
totalNumberOfPixels2 = rows2 * columns2;
percentBlackPixels2 = 100.0 * numberOfBlackPixels2 /totalNumberOfPixels2;



imagefiles = dir('imgR*.jpg');      
nfiles = length(imagefiles);    % Number of files found
for ii=1:nfiles
%    currentfilename = imagefiles(ii).name;
%    currentimage = imread(currentfilename);
end
 imwrite(grayImage2, sprintf('imgR%d.jpg',ii));

imagefiles1 = dir('imgL*.jpg');      
nfiles1 = length(imagefiles1);    % Number of files found
for ii1=1:nfiles1
%    currentfilename1 = imagefiles(ii1).name;
%    currentimage1 = imread(currentfilename1);
end
 imwrite(grayImage1, sprintf('imgL%d.jpg',ii1));
 
 
 numberOfBlackPixel= [percentBlackPixels1, percentBlackPixels2];

end