xhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0);

// Compare two images
TemplateMatch[] matchings = tm.ProcessImage( image1, image2 );

// Check similarity level
if (matchings[0].Similarity > 0.95)
{
    // Do something with quite similar images
}