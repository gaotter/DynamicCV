import { DynamicCvAppPage } from './app.po';

describe('dynamic-cv-app App', () => {
  let page: DynamicCvAppPage;

  beforeEach(() => {
    page = new DynamicCvAppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
